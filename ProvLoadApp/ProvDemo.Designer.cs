namespace ProvLoadApp
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lastValue = new System.Windows.Forms.RichTextBox();
            this.testControls = new System.Windows.Forms.GroupBox();
            this.readCount = new System.Windows.Forms.Label();
            this.lastKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fireDelayMs = new System.Windows.Forms.TextBox();
            this.Limit = new System.Windows.Forms.Label();
            this.LimitTxt = new System.Windows.Forms.TextBox();
            this.KeyPatternTxt = new System.Windows.Forms.TextBox();
            this.getKeys = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.keyList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connStatus = new System.Windows.Forms.Label();
            this.Channel = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.testControls.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 581);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lastValue);
            this.tabPage1.Controls.Add(this.testControls);
            this.tabPage1.Controls.Add(this.keyList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Channel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lastValue
            // 
            this.lastValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lastValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastValue.Location = new System.Drawing.Point(-1, 93);
            this.lastValue.Name = "lastValue";
            this.lastValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lastValue.Size = new System.Drawing.Size(594, 462);
            this.lastValue.TabIndex = 33;
            this.lastValue.Text = "";
            this.lastValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lastValue_MouseDoubleClick);
            // 
            // testControls
            // 
            this.testControls.Controls.Add(this.readCount);
            this.testControls.Controls.Add(this.lastKey);
            this.testControls.Controls.Add(this.label2);
            this.testControls.Controls.Add(this.label3);
            this.testControls.Controls.Add(this.fireDelayMs);
            this.testControls.Controls.Add(this.Limit);
            this.testControls.Controls.Add(this.LimitTxt);
            this.testControls.Controls.Add(this.KeyPatternTxt);
            this.testControls.Controls.Add(this.getKeys);
            this.testControls.Controls.Add(this.stopBtn);
            this.testControls.Controls.Add(this.startBtn);
            this.testControls.Location = new System.Drawing.Point(-4, -3);
            this.testControls.Name = "testControls";
            this.testControls.Size = new System.Drawing.Size(596, 97);
            this.testControls.TabIndex = 31;
            this.testControls.TabStop = false;
            // 
            // readCount
            // 
            this.readCount.AutoSize = true;
            this.readCount.Location = new System.Drawing.Point(431, 54);
            this.readCount.Name = "readCount";
            this.readCount.Size = new System.Drawing.Size(62, 13);
            this.readCount.TabIndex = 31;
            this.readCount.Text = "Read so far";
            // 
            // lastKey
            // 
            this.lastKey.Location = new System.Drawing.Point(60, 70);
            this.lastKey.Name = "lastKey";
            this.lastKey.Size = new System.Drawing.Size(531, 20);
            this.lastKey.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last item";
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
            // fireDelayMs
            // 
            this.fireDelayMs.Location = new System.Drawing.Point(114, 43);
            this.fireDelayMs.Name = "fireDelayMs";
            this.fireDelayMs.Size = new System.Drawing.Size(37, 20);
            this.fireDelayMs.TabIndex = 24;
            this.fireDelayMs.Text = "0";
            this.fireDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Limit
            // 
            this.Limit.AutoSize = true;
            this.Limit.Location = new System.Drawing.Point(321, 14);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(36, 13);
            this.Limit.TabIndex = 28;
            this.Limit.Text = "limit to";
            // 
            // LimitTxt
            // 
            this.LimitTxt.Location = new System.Drawing.Point(359, 10);
            this.LimitTxt.Name = "LimitTxt";
            this.LimitTxt.Size = new System.Drawing.Size(64, 20);
            this.LimitTxt.TabIndex = 22;
            this.LimitTxt.Text = "1000";
            // 
            // KeyPatternTxt
            // 
            this.KeyPatternTxt.Location = new System.Drawing.Point(185, 10);
            this.KeyPatternTxt.Name = "KeyPatternTxt";
            this.KeyPatternTxt.Size = new System.Drawing.Size(130, 20);
            this.KeyPatternTxt.TabIndex = 21;
            this.KeyPatternTxt.Text = ".*";
            // 
            // getKeys
            // 
            this.getKeys.Location = new System.Drawing.Point(8, 9);
            this.getKeys.Name = "getKeys";
            this.getKeys.Size = new System.Drawing.Size(173, 23);
            this.getKeys.TabIndex = 20;
            this.getKeys.Text = "Get sample keys for pattern";
            this.getKeys.UseVisualStyleBackColor = true;
            this.getKeys.Click += new System.EventHandler(this.getKeys_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(348, 36);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 25;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(8, 41);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 23);
            this.startBtn.TabIndex = 23;
            this.startBtn.Text = "Start with delay of";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // keyList
            // 
            this.keyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.keyList.FullRowSelect = true;
            this.keyList.LabelEdit = true;
            this.keyList.LabelWrap = false;
            this.keyList.Location = new System.Drawing.Point(593, -3);
            this.keyList.MultiSelect = false;
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(188, 562);
            this.keyList.TabIndex = 32;
            this.keyList.UseCompatibleStateImageBehavior = false;
            this.keyList.View = System.Windows.Forms.View.Details;
            this.keyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDoubleClick);
            this.keyList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDown);
            this.keyList.Resize += new System.EventHandler(this.keyList_Resize);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "with";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 20);
            this.textBox5.TabIndex = 47;
            this.textBox5.Text = "01.01.1970 00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Read so far";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Last item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "ms between reads";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(2, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(774, 480);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(336, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "limit to";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "1000";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Start after";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(4, 6);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(61, 20);
            this.ip.TabIndex = 22;
            this.ip.Text = "127.0.0.1";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(346, 3);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 28;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Checked = true;
            this.ssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ssl.Location = new System.Drawing.Point(304, 8);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(46, 17);
            this.ssl.TabIndex = 27;
            this.ssl.Text = "SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(212, 6);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 26;
            this.password.Text = "change_on_install";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(116, 6);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 25;
            this.user.Text = "admin";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(71, 6);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(39, 20);
            this.port.TabIndex = 24;
            this.port.Text = "8124";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = ":";
            // 
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.Location = new System.Drawing.Point(431, 9);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(94, 13);
            this.connStatus.TabIndex = 29;
            this.connStatus.Text = "Connection Status";
            this.connStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connStatus_MouseClick);
            // 
            // Channel
            // 
            this.Channel.Location = new System.Drawing.Point(718, 2);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(66, 20);
            this.Channel.TabIndex = 30;
            this.Channel.Text = "MBSNT";
            // 
            // ProvDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 614);
            this.Controls.Add(this.Channel);
            this.Controls.Add(this.connStatus);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.ssl);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ProvDemo";
            this.Text = "Provisioning Demo";
            this.Load += new System.EventHandler(this.ProvDemo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.testControls.ResumeLayout(false);
            this.testControls.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox lastValue;
        private System.Windows.Forms.GroupBox testControls;
        private System.Windows.Forms.Label readCount;
        private System.Windows.Forms.TextBox lastKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fireDelayMs;
        private System.Windows.Forms.Label Limit;
        private System.Windows.Forms.TextBox LimitTxt;
        private System.Windows.Forms.TextBox KeyPatternTxt;
        private System.Windows.Forms.Button getKeys;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ListView keyList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label connStatus;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Channel;
        private System.Windows.Forms.Label label8;
    }
}

