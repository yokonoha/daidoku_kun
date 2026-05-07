using AI.Talk.Editor.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspeechtest
{
    public partial class Form1 : Form
    {
        private TtsControl _ttsControl;
        //ReCaffeineSDK IMPLEMENTATION
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private bool _disposed = false;

        public Form1()
        {
            
            InitializeComponent();
            if (Properties.Settings.Default.enablerecafsdk)
            {
                _ = extserverstart();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var screenArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                screenArea.Width - this.Width,
                screenArea.Height - this.Height
            );
        }

        //ReCaffeineSDK

        private async Task extserverstart()
        {
            //receive
            await Task.Run(async () =>
            {
                using (var server = new NamedPipeServerStream("c4pextpipe2", PipeDirection.In))
                {
                    while (true)
                    {
                        try
                        {
                            await server.WaitForConnectionAsync();
                            using (var reader = new StreamReader(server, Encoding.UTF8, true, 1024, leaveOpen: true))
                            {
                                string message = await reader.ReadLineAsync();
                                //受信したメッセージを処理
                                this.Invoke(new Action(() =>
                                {
                                  
                                    
                                    string givenstore = message;
                                    string process1 = givenstore.Replace(",", "_");
                                    givenstore = process1;
                                    string process2 = givenstore.Replace("C4P:value:", ",").Replace("_YoK:oHa_", " ");
                                    string[] lst = process2.Split(',');
                                    string tit = lst[1];
                                    textBox2.AppendText("読み上げ文章[RCFext]:"+lst[1] + Environment.NewLine);
                                    try
                                    {

                                        if (_ttsControl != null && _ttsControl.Status == HostStatus.Idle)
                                        {

                                            _ttsControl.Text = tit;
                                            _ttsControl.Play();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("音声の再生に失敗しました。\n" + ex.Message);
                                    }
                                }));
                            }
                            if (server.IsConnected)
                            {
                                server.Disconnect();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"拡張機能からの受信に失敗: {ex.Message}"); Debug.WriteLine(ex.Message);
                            await Task.Delay(1000);
                        }
                    }
                }
            });
        }

        subttl subttl = new subttl();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                _ttsControl = new TtsControl();

                // 2. 利用可能なホスト一覧を取得する
                var availableHosts = _ttsControl.GetAvailableHostNames();
                if (availableHosts == null || availableHosts.Length == 0)
                {
                    MessageBox.Show("利用可能な対応ソフトが見つかりません。");
                    return;
                }
                if (!Properties.Settings.Default.nomsgonboot)
                {
                    MessageBox.Show("利用可能な対応ソフトが見つかりました: " + string.Join(", ", availableHosts));
                }
                

                _ttsControl.Initialize(availableHosts[0]);


                if (_ttsControl.Status == HostStatus.NotRunning)
                {
                    _ttsControl.StartHost();
                }
                _ttsControl.Connect();
                StartServer();

                timer1.Start();

                //自動起動設定のところ。
                if(Properties.Settings.Default.automatecharaview)
                {
                    if(Application.OpenForms["charaform"] is charaform openForm)
                    {
                        openForm.Close();
                    }
                    charaform form = new charaform();
                    form.Show();
                }
                if (Properties.Settings.Default.automatevct)
                {
                    button4.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("対応ソフトへの接続に失敗しました。\n" + ex.Message);
            }
            if (Properties.Settings.Default.enablerecafsdk)
            {
                button5.Visible = true;
            }
            subttl.Show();
        }
        private void SafePlay(string text)
        {
            try
            {
                // chk connectivity
                if (_ttsControl == null || _ttsControl.Status == HostStatus.NotConnected)
                {
                    // retry
                    var hosts = _ttsControl.GetAvailableHostNames();
                    if (hosts.Length > 0)
                    {
                        _ttsControl.Initialize(hosts[0]);
                        _ttsControl.Connect();
                    }
                }

                //話す!
                _ttsControl.Text = text;
                _ttsControl.Play();
            }
            catch (Exception ex)
            {
                //フリーズ対策
                Console.WriteLine("再生エラー（再試行が必要）: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //手動読み込み用(いらない..?)
                if (_ttsControl != null && _ttsControl.Status == HostStatus.Idle)
                {
                    
                    _ttsControl.Text = textBox1.Text;
                    _ttsControl.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("音声の再生に失敗しました。\n" + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_ttsControl != null)
                {
                    _ttsControl.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("エラー: " + ex.Message);
            }
        }
        
        private async void StartServer()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");

            try
            {
                listener.Start();
                labelStatus.Text = "サーバー稼働中...";
            }
            catch (HttpListenerException)
            {
                MessageBox.Show("管理者権限で実行するか、ポートを確認してください。");
                return;
            }

            while (true)
            {
              
                HttpListenerContext context = await listener.GetContextAsync();
                HttpListenerRequest request = context.Request;

                //エンドポイントsettings!
                string rawText = request.Url.Query;
                var queryParams = System.Web.HttpUtility.ParseQueryString(rawText, Encoding.UTF8);//URLエンコ済みのものをデコード
                string text = queryParams["text"];

                if (!string.IsNullOrEmpty(text))
                {
                    this.Invoke(new Action(() => {
                        SafePlay(text);

                        textBox2.AppendText($"読み上げ受信（正常）: {text}\r\n");
                        subttl.textBox1.Text= text;
                    }));
                }


                byte[] buffer = Encoding.UTF8.GetBytes("OK");
                context.Response.AddHeader("Access-Control-Allow-Origin", "*"); // 一応CORS
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_ttsControl != null && _ttsControl.Status == HostStatus.Idle)
            {
                try
                {
                   
                    var v = _ttsControl.Version;
                }
                catch (Exception ex){ Console.WriteLine("エラー: " + ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(Application.OpenForms["charaform"] is charaform openForm)
            {
                openForm.Close();
            }
            else
            {

                charaform form = new charaform();
                form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //voicecontoolにアクセスするだけ
            System.Diagnostics.Process.Start("https://yokonoha.github.io/voicecontool");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settingsactivity settingsactivity = new settingsactivity();
            settingsactivity.Show();
        }
        

        //ReCaffeineSDK
        public void Dispose()
        {
            if (_disposed) return;

            _cts.Cancel();
            _cts.Dispose();
            _disposed = true;
            Console.WriteLine("[ReCaffeine SDK] Cleaned up resources.");
        }



        ~Form1() 
        {
            Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.enablerecafsdk)
            {
                using (var client = new NamedPipeClientStream(".", "c4pextpipe", PipeDirection.Out))
                {
                    try
                    {
                        client.Connect(2000);
                        using (var writer = new StreamWriter(client))
                        {
                            writer.AutoFlush = true;
                            writer.WriteLine("getinfo");
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"拡張機能への送信に失敗: {ex.Message}"); Debug.WriteLine(ex.Message);

                    }

                }
               


            }

        }
    }
}
