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
    public partial class settingsactivity : Form
    {
        public settingsactivity()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.iscustomtachieenabled = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.iscustomtachieenabled = false;
                Properties.Settings.Default.Save();
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            //実行元ディレクトリにあるtaticheフォルダにある画像(a.png~d.png)のpathをresourcesにそれぞれ記録
            //存在チェック
            string basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tachie");
                        if (!System.IO.Directory.Exists(basePath))
            {
                MessageBox.Show("tachieフォルダが見つかりませんでした。実行元ディレクトリにtachieフォルダを作成し、その中にa.png~d.pngを配置してください。配置先:"+basePath);
                return;
            }
            else
            {
                string flag = "0";
                string[] requiredFiles = { "a.png", "b.png", "c.png", "d.png" };
                foreach (string file in requiredFiles)
                {
                    string filePath = System.IO.Path.Combine(basePath, file);
                    if (!System.IO.File.Exists(filePath))
                    {
                        MessageBox.Show($"{file}が見つかりませんでした。tachieフォルダの中に{file}を配置してください。配置先:"+filePath);
                        
                        return;
                    }
                    else
                    {
                        flag = "1"; 
                        
                    }

                }
                    if (flag=="1")
                    {
                        //a.png
                        Properties.Settings.Default.ake_open = System.IO.Path.Combine(basePath, "a.png");
                        //b.png
                        Properties.Settings.Default.ake_blink = System.IO.Path.Combine(basePath, "b.png");
                        //c.png
                        Properties.Settings.Default.toji_open = System.IO.Path.Combine(basePath, "c.png");
                        //d.png
                        Properties.Settings.Default.toji_blink = System.IO.Path.Combine(basePath, "d.png");
                        Properties.Settings.Default.Save();
                        checkBox1.Checked = true;
                        MessageBox.Show("画像のパスを登録し、カスタム立ち絵を有効にしました。\ntachieフォルダの中身を削除した場合はカスタム立ち絵を使用するチェックボックスのチェックを必ず外してください。");
                    }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.automatecharaview = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.automatecharaview = false;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Properties.Settings.Default.nomsgonboot = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.nomsgonboot = false;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Properties.Settings.Default.automatevct = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.automatevct = false;
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yokonoha.pages.dev/daidokuhelp.html");
        }

        private void settingsactivity_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.iscustomtachieenabled)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (Properties.Settings.Default.automatecharaview)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            if (Properties.Settings.Default.nomsgonboot)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
            if (Properties.Settings.Default.automatevct)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            osl osl = new osl();
            osl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("このソフトと連携したソフトは比較的簡単に作れちゃいます! 本ソフトウェアのリポジトリにあるdec.jsをご自身のサーバーにアップロードしてご利用ください!");
            System.Diagnostics.Process.Start("https://github.com/yokonoha/daidoku_kun");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thanks thanks = new thanks();
            thanks.Show();
        }
    }
}
