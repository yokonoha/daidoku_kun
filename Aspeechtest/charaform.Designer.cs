namespace Aspeechtest
{
    partial class charaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(charaform));
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.eyeblinkdurationTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.サイズ変更モードにするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立ち絵モードに戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上下移動の有効化無効化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // blinkTimer
            // 
            this.blinkTimer.Interval = 3470;
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // eyeblinkdurationTimer
            // 
            this.eyeblinkdurationTimer.Interval = 150;
            this.eyeblinkdurationTimer.Tick += new System.EventHandler(this.eyeblinkdurationTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.サイズ変更モードにするToolStripMenuItem,
            this.立ち絵モードに戻すToolStripMenuItem,
            this.上下移動の有効化無効化ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 70);
            // 
            // サイズ変更モードにするToolStripMenuItem
            // 
            this.サイズ変更モードにするToolStripMenuItem.Name = "サイズ変更モードにするToolStripMenuItem";
            this.サイズ変更モードにするToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.サイズ変更モードにするToolStripMenuItem.Text = "サイズ変更モードにする";
            this.サイズ変更モードにするToolStripMenuItem.Click += new System.EventHandler(this.サイズ変更モードにするToolStripMenuItem_Click);
            // 
            // 立ち絵モードに戻すToolStripMenuItem
            // 
            this.立ち絵モードに戻すToolStripMenuItem.Name = "立ち絵モードに戻すToolStripMenuItem";
            this.立ち絵モードに戻すToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.立ち絵モードに戻すToolStripMenuItem.Text = "立ち絵モードに戻す";
            this.立ち絵モードに戻すToolStripMenuItem.Click += new System.EventHandler(this.立ち絵モードに戻すToolStripMenuItem_Click);
            // 
            // 上下移動の有効化無効化ToolStripMenuItem
            // 
            this.上下移動の有効化無効化ToolStripMenuItem.Name = "上下移動の有効化無効化ToolStripMenuItem";
            this.上下移動の有効化無効化ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.上下移動の有効化無効化ToolStripMenuItem.Text = "上下移動の無効化/有効化";
            this.上下移動の有効化無効化ToolStripMenuItem.Click += new System.EventHandler(this.上下移動の有効化無効化ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "代読くん";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Aspeechtest.Properties.Resources.placeholderhina;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // charaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(534, 435);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "charaform";
            this.Text = "立ち絵表示";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.charaform_FormClosing);
            this.Load += new System.EventHandler(this.charaform_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Timer eyeblinkdurationTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem サイズ変更モードにするToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立ち絵モードに戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上下移動の有効化無効化ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer2;
    }
}