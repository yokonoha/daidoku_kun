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
    public partial class subttl : Form
    {
        public subttl()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);

            var screenArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                0,
                screenArea.Height - this.Height
            );
        }

        Point lastPoint;


        private void 字幕フォント設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textboxのfontを変更するダイアログを表示
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;

                this.Top += e.Y - lastPoint.Y;


            }
        }
    }
}
