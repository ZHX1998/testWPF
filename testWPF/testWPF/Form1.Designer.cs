namespace testWPF
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenBuzz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabpages = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.media_stop = new System.Windows.Forms.Button();
            this.media_pause = new System.Windows.Forms.Button();
            this.media_play = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startrecord = new System.Windows.Forms.Button();
            this.stoprecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabpages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 40.25F);
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(678, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "连铸浇注异常情况预警系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabpages);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 100);
            this.tabControl1.Location = new System.Drawing.Point(3, 118);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 514);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stoprecord);
            this.tabPage2.Controls.Add(this.startrecord);
            this.tabPage2.Controls.Add(this.OpenBuzz);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.videoSourcePlayer1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "监控";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // OpenBuzz
            // 
            this.OpenBuzz.Font = new System.Drawing.Font("宋体", 10F);
            this.OpenBuzz.Location = new System.Drawing.Point(249, 428);
            this.OpenBuzz.Name = "OpenBuzz";
            this.OpenBuzz.Size = new System.Drawing.Size(48, 26);
            this.OpenBuzz.TabIndex = 8;
            this.OpenBuzz.Text = "打开";
            this.OpenBuzz.UseVisualStyleBackColor = true;
            this.OpenBuzz.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "false";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(94, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "报警器状态：";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(61, 45);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(402, 359);
            this.videoSourcePlayer1.TabIndex = 5;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10F);
            this.button2.Location = new System.Drawing.Point(587, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(587, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 359);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tabpages
            // 
            this.tabpages.Controls.Add(this.button1);
            this.tabpages.Controls.Add(this.media_stop);
            this.tabpages.Controls.Add(this.media_pause);
            this.tabpages.Controls.Add(this.media_play);
            this.tabpages.Controls.Add(this.pictureBox3);
            this.tabpages.Controls.Add(this.label4);
            this.tabpages.Controls.Add(this.listBox1);
            this.tabpages.Controls.Add(this.mediaPlayer);
            this.tabpages.Font = new System.Drawing.Font("宋体", 10F);
            this.tabpages.Location = new System.Drawing.Point(104, 4);
            this.tabpages.Name = "tabpages";
            this.tabpages.Padding = new System.Windows.Forms.Padding(3);
            this.tabpages.Size = new System.Drawing.Size(1073, 506);
            this.tabpages.TabIndex = 2;
            this.tabpages.Text = "播放";
            this.tabpages.UseVisualStyleBackColor = true;
            this.tabpages.Click += new System.EventHandler(this.tabpages_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(584, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // media_stop
            // 
            this.media_stop.Location = new System.Drawing.Point(416, 461);
            this.media_stop.Name = "media_stop";
            this.media_stop.Size = new System.Drawing.Size(46, 25);
            this.media_stop.TabIndex = 10;
            this.media_stop.Text = "停止";
            this.media_stop.UseVisualStyleBackColor = true;
            this.media_stop.Click += new System.EventHandler(this.media_stop_Click);
            // 
            // media_pause
            // 
            this.media_pause.Font = new System.Drawing.Font("宋体", 10F);
            this.media_pause.Location = new System.Drawing.Point(268, 461);
            this.media_pause.Name = "media_pause";
            this.media_pause.Size = new System.Drawing.Size(46, 24);
            this.media_pause.TabIndex = 8;
            this.media_pause.Text = "暂停";
            this.media_pause.UseVisualStyleBackColor = true;
            this.media_pause.Click += new System.EventHandler(this.media_pause_Click);
            // 
            // media_play
            // 
            this.media_play.Font = new System.Drawing.Font("宋体", 10F);
            this.media_play.Location = new System.Drawing.Point(139, 460);
            this.media_play.Name = "media_play";
            this.media_play.Size = new System.Drawing.Size(46, 25);
            this.media_play.TabIndex = 9;
            this.media_play.Text = "播放";
            this.media_play.UseVisualStyleBackColor = true;
            this.media_play.Click += new System.EventHandler(this.media_play_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(46, 455);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(635, 30);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "播放列表:";
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(826, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 459);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(46, 24);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(635, 461);
            this.mediaPlayer.TabIndex = 5;
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.56495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.43504F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.77726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.22274F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1288, 729);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // startrecord
            // 
            this.startrecord.Font = new System.Drawing.Font("宋体", 10F);
            this.startrecord.Location = new System.Drawing.Point(498, 68);
            this.startrecord.Name = "startrecord";
            this.startrecord.Size = new System.Drawing.Size(75, 23);
            this.startrecord.TabIndex = 9;
            this.startrecord.Text = "开始录制";
            this.startrecord.UseVisualStyleBackColor = true;
            this.startrecord.Click += new System.EventHandler(this.startrecord_Click);
            // 
            // stoprecord
            // 
            this.stoprecord.Font = new System.Drawing.Font("宋体", 10F);
            this.stoprecord.Location = new System.Drawing.Point(498, 153);
            this.stoprecord.Name = "stoprecord";
            this.stoprecord.Size = new System.Drawing.Size(75, 23);
            this.stoprecord.TabIndex = 10;
            this.stoprecord.Text = "停止录制";
            this.stoprecord.UseVisualStyleBackColor = true;
            this.stoprecord.Click += new System.EventHandler(this.stoprecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "连铸浇注异常情况预警系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabpages.ResumeLayout(false);
            this.tabpages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.TabPage tabpages;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button OpenBuzz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button media_stop;
        private System.Windows.Forms.Button media_play;
        private System.Windows.Forms.Button media_pause;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button stoprecord;
        private System.Windows.Forms.Button startrecord;
    }
}

