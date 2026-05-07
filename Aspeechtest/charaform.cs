using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspeechtest
{
    public partial class charaform : Form
    {
        //立ち絵最終CHKフラグ。
        private bool iscustomtatchieok = false;
        private MMDevice defaultDevice;
        //キャッシュ用
        private Image ake_open;
        private Image ake_blink;
        private Image toji_open;
        private Image toji_blink;
        //表情コントロール用フラグ
        private bool isMouthAke = false;
        private bool isEyeOpen = true;

        // 口パク乱数
        private Timer mouthTimer;
        private Random rnd = new Random();
        // 開閉のランダム間隔（ms）
        private int mouthOpenMin = 80;
        private int mouthOpenMax = 220;
        private int mouthCloseMin = 40;
        private int mouthCloseMax = 120;

        public charaform()
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = this.BackColor;
            this.TopMost = true;
            InitializeComponent();
            var enumerator = new MMDeviceEnumerator();
            defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            timer1.Start();

            // 後付け。
            mouthTimer = new Timer();
            mouthTimer.Tick += mouthTimer_Tick;

        }
        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);

            var screenArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                0,
                screenArea.Height - this.Height
            ); }

        Point lastPoint;
        private void charaform_Load(object sender, EventArgs e)
        {            

            timer2.Start();
            if(Properties.Settings.Default.xy != null)
            {
                this.Size = Properties.Settings.Default.xy;
            }

            pictureBox1.AllowDrop = true;
            if (Properties.Settings.Default.iscustomtachieenabled)
            {
                //一応存在チェック
                if (System.IO.File.Exists(Properties.Settings.Default.ake_open) &&
                    System.IO.File.Exists(Properties.Settings.Default.ake_blink) &&
                    System.IO.File.Exists(Properties.Settings.Default.toji_open) &&
                    System.IO.File.Exists(Properties.Settings.Default.toji_blink))
                {
                    ake_open = Image.FromFile(Properties.Settings.Default.ake_open);
                    ake_blink = Image.FromFile(Properties.Settings.Default.ake_blink);
                    toji_open = Image.FromFile(Properties.Settings.Default.toji_open);
                    toji_blink = Image.FromFile(Properties.Settings.Default.toji_blink);
                    pictureBox1.Image = ake_open;
                    iscustomtatchieok = true;
                }
                else
                {
                    MessageBox.Show("カスタム立ち絵の画像が見つかりませんでした。設定を確認してください。");
                    Properties.Settings.Default.iscustomtachieenabled = false;
                    Properties.Settings.Default.Save();
                    ake_open = Properties.Resources.test0001;
                    ake_blink = Properties.Resources.test0002;
                    toji_open = Properties.Resources.test0000;
                    toji_blink = Properties.Resources.test0003;
                    pictureBox1.Image = ake_open;
                    iscustomtatchieok = false;
                }
                blinkTimer.Start();

            }
            else
            {
                ake_open = Properties.Resources.test0001;
                ake_blink = Properties.Resources.test0002;
                toji_open = Properties.Resources.test0000;
                toji_blink = Properties.Resources.test0003;
                pictureBox1.Image = ake_open;
                iscustomtatchieok = false;
                blinkTimer.Start();
            }
        }
        private void UpdateCharState()
        {
            if (isMouthAke)
            {
                if (isEyeOpen)
                {
                    pictureBox1.Image = ake_open;
                }
                else
                {
                    pictureBox1.Image = ake_blink;
                }
            }
            else
            {
                if (isEyeOpen)
                {
                    pictureBox1.Image = toji_open;
                }
                else
                {
                    pictureBox1.Image = toji_blink;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                if (!Properties.Settings.Default.isupdownmovable&&iscustomtatchieok)//逆にしてあります(手抜き)
                {
                    this.Top += e.Y - lastPoint.Y;
                }

            }
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            isEyeOpen = false;
            UpdateCharState();
            eyeblinkdurationTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float peak = defaultDevice.AudioMeterInformation.MasterPeakValue;
            double dB = (peak > 0) ? 20 * Math.Log10(peak) : -60.0;

            // 口パク判定
            double threshold = -40.0;

            if (dB > threshold)
            {
                // 音声がある間はランダム開閉
                if (!mouthTimer.Enabled)
                {
                    
                    isMouthAke = true;
                    UpdateCharState();
                    mouthTimer.Interval = rnd.Next(mouthOpenMin, mouthOpenMax);
                    mouthTimer.Start();
                }
            }
            else
            {
                
                if (mouthTimer.Enabled) mouthTimer.Stop();
                isMouthAke = false;
                UpdateCharState();
            }


            UpdateCharState();
        }

        private void mouthTimer_Tick(object sender, EventArgs e)
        {
            // 次の間隔をランダム設定
            isMouthAke = !isMouthAke;
            UpdateCharState();
            if (isMouthAke)
            {
                mouthTimer.Interval = rnd.Next(mouthOpenMin, mouthOpenMax);
            }
            else
            {
                mouthTimer.Interval = rnd.Next(mouthCloseMin, mouthCloseMax);
            }
        }

        private void eyeblinkdurationTimer_Tick(object sender, EventArgs e)
        {
            isEyeOpen = true;
            UpdateCharState();
            eyeblinkdurationTimer.Stop();
        }

        private void サイズ変更モードにするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.TransparencyKey = Color.Magenta;
        }

        private void 立ち絵モードに戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.xy = this.Size;
            Properties.Settings.Default.Save();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;
        }

        private void 上下移動の有効化無効化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isupdownmovable = !Properties.Settings.Default.isupdownmovable;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.isupdownmovable)
            {
                notifyIcon1.ShowBalloonTip(1000, "通知", "上下自由移動が有効になりました。", ToolTipIcon.Info);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(1000, "通知", "上下自由移動が無効になりました。", ToolTipIcon.Info);
            }
        }

        private void charaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.xy = this.Size;
          
            Properties.Settings.Default.Save();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.xy = this.Size;
         
            Properties.Settings.Default.Save();
        }

        private void 即席字幕を表示するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subttl sub = new subttl();
            sub.Show();
        }
    }
}
