namespace Aspeechtest
{
    partial class settingsactivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsactivity));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.helptxt = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F);
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "一般設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F);
            this.label2.Location = new System.Drawing.Point(8, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "キャラ立ち絵表示設定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F);
            this.label3.Location = new System.Drawing.Point(8, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "VoiceConTool設定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("メイリオ", 12F);
            this.label4.Location = new System.Drawing.Point(8, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "その他";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 10F);
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "オープンソースライセンス表示";
            this.helptxt.SetToolTip(this.button1, "当ソフトに使用させていただいたライブラリ等のライセンスを表示します");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 10F);
            this.button2.Location = new System.Drawing.Point(12, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "製作者・謝辞";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.checkBox1.Location = new System.Drawing.Point(197, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "カスタム立ち絵を自動適用";
            this.helptxt.SetToolTip(this.checkBox1, "右のボタンから立ち絵をお好みのものに置き換えます。(事前準備が必要です。画面右上取説をご覧ください!)\r\n");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("メイリオ", 10F);
            this.button3.Location = new System.Drawing.Point(293, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "取説はこちら";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 10F);
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "使い方が分からない! そんな時は... ==>";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("メイリオ", 9F);
            this.button4.Location = new System.Drawing.Point(20, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "カスタム立ち絵をセット";
            this.helptxt.SetToolTip(this.button4, "カスタム立ち絵を設定します。");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("メイリオ", 9F);
            this.checkBox2.Location = new System.Drawing.Point(26, 209);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 22);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "キャラ表示を同時起動";
            this.helptxt.SetToolTip(this.checkBox2, "\"キャラ配置\"ボタンを押さなくても起動時に自動表示させるようにする設定です。");
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("メイリオ", 9F);
            this.checkBox3.Location = new System.Drawing.Point(26, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(243, 22);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "起動時に連携ソフトの確認表示をしない";
            this.helptxt.SetToolTip(this.checkBox3, "\"キャラ配置\"ボタンを押さなくても起動時に自動表示させるようにする設定です。\r\nワンクリックで起動できるようになりますが、対応ソフトが複数ある場合に問題が発生する" +
        "場合もあります(未検証)");
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("メイリオ", 9F);
            this.checkBox4.Location = new System.Drawing.Point(26, 270);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(111, 22);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "VCTを同時起動";
            this.helptxt.SetToolTip(this.checkBox4, "\"VCT\"ボタンを押さなくても起動時に自動表示させるようにする設定です。\r\nすぐに実況や代読準備ができます。");
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("メイリオ", 10F);
            this.button5.Location = new System.Drawing.Point(12, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 38);
            this.button5.TabIndex = 13;
            this.button5.Text = "対応ソフトを作るには?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("メイリオ", 9F);
            this.checkBox5.Location = new System.Drawing.Point(26, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(169, 22);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "自動更新を無効化(非推奨)";
            this.helptxt.SetToolTip(this.checkBox5, "起動時に代読くんの更新の有無を確認しないようにします。\r\n製作者からの指示があった場合にオンにしてください。通常はオフ推奨です。");
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // settingsactivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(434, 466);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsactivity";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.settingsactivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolTip helptxt;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}