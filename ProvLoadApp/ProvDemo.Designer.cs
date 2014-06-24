namespace WindowsFormsApplication1
{
    partial class ProvDemo
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.keyList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Limit = new System.Windows.Forms.Label();
            this.LimitTxt = new System.Windows.Forms.TextBox();
            this.KeyPatternTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.KeyMatch = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.connStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(0, 123);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(591, 491);
            this.textBox4.TabIndex = 9;
            // 
            // keyList
            // 
            this.keyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyList.FullRowSelect = true;
            this.keyList.LabelEdit = true;
            this.keyList.LabelWrap = false;
            this.keyList.Location = new System.Drawing.Point(597, 0);
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(169, 614);
            this.keyList.TabIndex = 8;
            this.keyList.UseCompatibleStateImageBehavior = false;
            this.keyList.View = System.Windows.Forms.View.List;
            this.keyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Limit);
            this.groupBox1.Controls.Add(this.LimitTxt);
            this.groupBox1.Controls.Add(this.KeyPatternTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.KeyMatch);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 97);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Read so far";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(509, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last key read";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ms between reads";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Limit
            // 
            this.Limit.AutoSize = true;
            this.Limit.Location = new System.Drawing.Point(486, 15);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(36, 13);
            this.Limit.TabIndex = 28;
            this.Limit.Text = "limit to";
            // 
            // LimitTxt
            // 
            this.LimitTxt.Location = new System.Drawing.Point(524, 13);
            this.LimitTxt.Name = "LimitTxt";
            this.LimitTxt.Size = new System.Drawing.Size(64, 20);
            this.LimitTxt.TabIndex = 22;
            this.LimitTxt.Text = "1000";
            // 
            // KeyPatternTxt
            // 
            this.KeyPatternTxt.Location = new System.Drawing.Point(308, 14);
            this.KeyPatternTxt.Name = "KeyPatternTxt";
            this.KeyPatternTxt.Size = new System.Drawing.Size(172, 20);
            this.KeyPatternTxt.TabIndex = 21;
            this.KeyPatternTxt.Text = ".*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Channel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Get sample keys for pattern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(513, 38);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 25;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // KeyMatch
            // 
            this.KeyMatch.Location = new System.Drawing.Point(57, 15);
            this.KeyMatch.Name = "KeyMatch";
            this.KeyMatch.Size = new System.Drawing.Size(66, 20);
            this.KeyMatch.TabIndex = 19;
            this.KeyMatch.Text = "MBSNT";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(8, 41);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 23);
            this.StartBtn.TabIndex = 23;
            this.StartBtn.Text = "Start with delay of";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connStatus);
            this.groupBox2.Controls.Add(this.connectBtn);
            this.groupBox2.Controls.Add(this.ssl);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.port);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 35);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(8, 13);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(61, 20);
            this.ip.TabIndex = 0;
            this.ip.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = ":";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(75, 13);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(39, 20);
            this.port.TabIndex = 3;
            this.port.Text = "8124";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(120, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 4;
            this.user.Text = "admin";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(216, 13);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 5;
            this.password.Text = "change_on_install";
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Checked = true;
            this.ssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ssl.Location = new System.Drawing.Point(308, 15);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(46, 17);
            this.ssl.TabIndex = 6;
            this.ssl.Text = "SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(350, 11);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.Location = new System.Drawing.Point(433, 15);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(0, 13);
            this.connStatus.TabIndex = 8;
            // 
            // ProvDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.keyList);
            this.Controls.Add(this.textBox4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "ProvDemo";
            this.Text = "Provisioning Demo";
            this.Load += new System.EventHandler(this.ProvDemo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView keyList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Limit;
        private System.Windows.Forms.TextBox LimitTxt;
        private System.Windows.Forms.TextBox KeyPatternTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox KeyMatch;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label connStatus;
    }
}

