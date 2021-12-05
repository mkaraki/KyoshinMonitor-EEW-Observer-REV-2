
namespace KyoshinMonitor_EEW_Observer_REV_2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage_apiconfig = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_kpapi_endpoint = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_apiconfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage_apiconfig);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(705, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "モニタ設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "モニタカラー設定";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表示モニタ設定";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "地表リアルタイム震度-JMA int.",
            "地表最大加速度-PGA(gal)",
            "地表最大速度-PGV(cm/s)",
            "地表最大変位-PGD(cm)",
            "地表0.125Hz速度応答-Response 0.125Hz(PGV[cm/s])",
            "地表0.250Hz速度応答-Response 0.250Hz(PGV[cm/s])",
            "地表0.500Hz速度応答-Response 0.500Hz(PGV[cm/s])",
            "地表1Hz速度応答-Response 1Hz(PGV[cm/s])",
            "地表2Hz速度応答-Response 2Hz(PGV[cm/s])",
            "地表4Hz速度応答-Response 4Hz(PGV[cm/s])",
            "地中リアルタイム震度-JMA int.",
            "地中最大加速度-PGA(gal)",
            "地中最大速度-PGV(cm/s)",
            "地中最大変位-PGD(cm)",
            "地中0.125Hz速度応答-Response 0.125Hz(PGV[cm/s])",
            "地中0.250Hz速度応答-Response 0.250Hz(PGV[cm/s])",
            "地中0.500Hz速度応答-Response 0.500Hz(PGV[cm/s])",
            "地中1Hz速度応答-Response 1Hz(PGV[cm/s])",
            "地中2Hz速度応答-Response 2Hz(PGV[cm/s])",
            "地中4Hz速度応答-Response 4Hz(PGV[cm/s])",
            "EEW予測震度-JMA int.",
            "長周期地震動モニタ-SVA int."});
            this.comboBox2.Location = new System.Drawing.Point(9, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(400, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "地表リアルタイム震度-JMA int.",
            "地表最大加速度-PGA(gal)",
            "地表最大速度-PGV(cm/s)",
            "地表最大変位-PGD(cm)",
            "地表0.125Hz速度応答-Response 0.125Hz(PGV[cm/s])",
            "地表0.250Hz速度応答-Response 0.250Hz(PGV[cm/s])",
            "地表0.500Hz速度応答-Response 0.500Hz(PGV[cm/s])",
            "地表1Hz速度応答-Response 1Hz(PGV[cm/s])",
            "地表2Hz速度応答-Response 2Hz(PGV[cm/s])",
            "地表4Hz速度応答-Response 4Hz(PGV[cm/s])",
            "地中リアルタイム震度-JMA int.",
            "地中最大加速度-PGA(gal)",
            "地中最大速度-PGV(cm/s)",
            "地中最大変位-PGD(cm)",
            "地中0.125Hz速度応答-Response 0.125Hz(PGV[cm/s])",
            "地中0.250Hz速度応答-Response 0.250Hz(PGV[cm/s])",
            "地中0.500Hz速度応答-Response 0.500Hz(PGV[cm/s])",
            "地中1Hz速度応答-Response 1Hz(PGV[cm/s])",
            "地中2Hz速度応答-Response 2Hz(PGV[cm/s])",
            "地中4Hz速度応答-Response 4Hz(PGV[cm/s])",
            "EEW予測震度-JMA int.",
            "長周期地震動モニタ-SVA int."});
            this.comboBox1.Location = new System.Drawing.Point(9, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "サブウインドウ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "メインウインドウ";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(705, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "音量設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(705, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "通知/その他設定";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(705, 404);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "about";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(47, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 3;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Khaki;
            this.button5.Location = new System.Drawing.Point(6, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "ソフト配布サイト";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(6, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "製作者ブログ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(9, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "更新確認";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "最新のバージョン:v-.-.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "現在のバージョン:v1.0.0 beta";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(219, 89);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(480, 307);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 279);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "作成協力";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "・Eq_F.iさん\r\n・なりかくんさん\r\n・mkarakiさん";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(472, 279);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "データ提供元";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 80);
            this.label5.TabIndex = 1;
            this.label5.Text = "(敬称略)\r\n・NIED\r\n・Kwatch24(強震モニタ24h)\r\n・なりかくん";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(472, 279);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "更新履歴";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(466, 273);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "----------------------------------Version 1.0.0 β--------------------------------" +
    "--\r\n・KMEO rev2の初期バージョン公開\r\n・KMEO rev1より安定性の向上、軽量化";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(212, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 66);
            this.label3.TabIndex = 1;
            this.label3.Text = "KyoshinMonitor EEW Observer\r\nVersion 1.0.0 Beta Develop Edition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(498, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(269, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "設定保存";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage_apiconfig
            // 
            this.tabPage_apiconfig.Controls.Add(this.groupBox3);
            this.tabPage_apiconfig.Location = new System.Drawing.Point(4, 24);
            this.tabPage_apiconfig.Name = "tabPage_apiconfig";
            this.tabPage_apiconfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_apiconfig.Size = new System.Drawing.Size(705, 404);
            this.tabPage_apiconfig.TabIndex = 5;
            this.tabPage_apiconfig.Text = "API設定";
            this.tabPage_apiconfig.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbox_kpapi_endpoint);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接続先API";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "kmoni Pretty API 準拠サーバ";
            // 
            // tbox_kpapi_endpoint
            // 
            this.tbox_kpapi_endpoint.Location = new System.Drawing.Point(6, 39);
            this.tbox_kpapi_endpoint.Name = "tbox_kpapi_endpoint";
            this.tbox_kpapi_endpoint.Size = new System.Drawing.Size(678, 21);
            this.tbox_kpapi_endpoint.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Text = "KyoshinMonitor EEW Observer - Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_apiconfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage_apiconfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbox_kpapi_endpoint;
        private System.Windows.Forms.Label label10;
    }
}