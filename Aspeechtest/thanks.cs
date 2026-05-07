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
    public partial class thanks : Form
    {
        public thanks()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aivoice.jp/manual/editor/api.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yokonoha.github.io/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/naudio/NAudio");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.enablerecafsdk=true;
            Properties.Settings.Default.Save();
            MessageBox.Show("ReCaffeine拡張機能を有効にしました。次回起動時からReCaffeine連携機能を使用します。");
        }
    }
}
