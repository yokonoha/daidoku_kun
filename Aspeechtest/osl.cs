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
    public partial class osl : Form
    {
        public osl()
        {
            InitializeComponent();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string url = e.LinkText;
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("リンクを開く際にエラーが発生しました: " + ex.Message);
            }
        }
    }
}
