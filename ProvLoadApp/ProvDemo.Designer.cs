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
            this.lastValue = new System.Windows.Forms.TextBox();
            this.keyList = new System.Windows.Forms.ListView();
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
            this.Channel = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.connStatus = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableChoose = new System.Windows.Forms.ComboBox();
            this.testControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastValue
            // 
            this.lastValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lastValue.Location = new System.Drawing.Point(0, 123);
            this.lastValue.Multiline = true;
            this.lastValue.Name = "lastValue";
            this.lastValue.Size = new System.Drawing.Size(591, 491);
            this.lastValue.TabIndex = 28;
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
            this.keyList.Size = new System.Drawing.Size(188, 614);
            this.keyList.TabIndex = 29;
            this.keyList.UseCompatibleStateImageBehavior = false;
            this.keyList.View = System.Windows.Forms.View.List;
            this.keyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDoubleClick);
            // 
            // testControls
            // 
            this.testControls.Controls.Add(this.tableChoose);
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
            this.testControls.Controls.Add(this.Channel);
            this.testControls.Controls.Add(this.startBtn);
            this.testControls.Location = new System.Drawing.Point(0, 27);
            this.testControls.Name = "testControls";
            this.testControls.Size = new System.Drawing.Size(596, 97);
            this.testControls.TabIndex = 19;
            this.testControls.TabStop = false;
            // 
            // readCount
            // 
            this.readCount.AutoSize = true;
            this.readCount.Location = new System.Drawing.Point(305, 54);
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
            this.fireDelayMs.Location = new System.Drawing.Point(114, 41);
            this.fireDelayMs.Name = "fireDelayMs";
            this.fireDelayMs.Size = new System.Drawing.Size(37, 20);
            this.fireDelayMs.TabIndex = 24;
            this.fireDelayMs.Text = "0";
            this.fireDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Limit
            // 
            this.Limit.AutoSize = true;
            this.Limit.Location = new System.Drawing.Point(486, 18);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(36, 13);
            this.Limit.TabIndex = 28;
            this.Limit.Text = "limit to";
            // 
            // LimitTxt
            // 
            this.LimitTxt.Location = new System.Drawing.Point(524, 14);
            this.LimitTxt.Name = "LimitTxt";
            this.LimitTxt.Size = new System.Drawing.Size(64, 20);
            this.LimitTxt.TabIndex = 22;
            this.LimitTxt.Text = "1000";
            // 
            // KeyPatternTxt
            // 
            this.KeyPatternTxt.Location = new System.Drawing.Point(350, 14);
            this.KeyPatternTxt.Name = "KeyPatternTxt";
            this.KeyPatternTxt.Size = new System.Drawing.Size(130, 20);
            this.KeyPatternTxt.TabIndex = 21;
            this.KeyPatternTxt.Text = ".*";
            // 
            // getKeys
            // 
            this.getKeys.Location = new System.Drawing.Point(173, 13);
            this.getKeys.Name = "getKeys";
            this.getKeys.Size = new System.Drawing.Size(173, 23);
            this.getKeys.TabIndex = 20;
            this.getKeys.Text = "Get sample keys for pattern";
            this.getKeys.UseVisualStyleBackColor = true;
            this.getKeys.Click += new System.EventHandler(this.getKeys_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(513, 38);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 25;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Channel
            // 
            this.Channel.Location = new System.Drawing.Point(101, 14);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(66, 20);
            this.Channel.TabIndex = 19;
            this.Channel.Text = "MBSNT";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Controls.Add(this.connStatus);
            this.groupBox2.Controls.Add(this.connectBtn);
            this.groupBox2.Controls.Add(this.ssl);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.port);
            this.groupBox2.Controls.Add(this.label4);
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
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.Location = new System.Drawing.Point(433, 15);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(0, 13);
            this.connStatus.TabIndex = 8;
            this.connStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connStatus_MouseClick);
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
            // password
            // 
            this.password.Location = new System.Drawing.Point(216, 13);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 5;
            this.password.Text = "change_on_install";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(120, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 4;
            this.user.Text = "admin";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(75, 13);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(39, 20);
            this.port.TabIndex = 3;
            this.port.Text = "8124";
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
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // tableChoose
            // 
            this.tableChoose.FormattingEnabled = true;
            this.tableChoose.Items.AddRange(new object[] {
            "Channel",
            "Audit"});
            this.tableChoose.Location = new System.Drawing.Point(8, 14);
            this.tableChoose.Name = "tableChoose";
            this.tableChoose.Size = new System.Drawing.Size(87, 21);
            this.tableChoose.TabIndex = 8;
            // 
            // ProvDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.testControls);
            this.Controls.Add(this.keyList);
            this.Controls.Add(this.lastValue);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ProvDemo";
            this.Text = "Provisioning Demo";
            this.Load += new System.EventHandler(this.ProvDemo_Load);
            this.testControls.ResumeLayout(false);
            this.testControls.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastValue;
        private System.Windows.Forms.ListView keyList;
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
        private System.Windows.Forms.TextBox Channel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label connStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ComboBox tableChoose;
    }
}

