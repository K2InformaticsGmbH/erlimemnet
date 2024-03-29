﻿namespace ProvLoadApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvDemo));
            this.bgChannelWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lastValue = new System.Windows.Forms.RichTextBox();
            this.testControls = new System.Windows.Forms.GroupBox();
            this.keysCount = new System.Windows.Forms.Label();
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
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.startTimeTxt = new System.Windows.Forms.TextBox();
            this.auditReadCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lastItemTxt = new System.Windows.Forms.RichTextBox();
            this.auditDelayTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.auditLimitTxt = new System.Windows.Forms.TextBox();
            this.stopAuditRead = new System.Windows.Forms.Button();
            this.startAuditRead = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connStatus = new System.Windows.Forms.Label();
            this.Channel = new System.Windows.Forms.TextBox();
            this.bgAuditWorker = new System.ComponentModel.BackgroundWorker();
            this.bgKeyLoadWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.testControls.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgChannelWorker
            // 
            this.bgChannelWorker.WorkerReportsProgress = true;
            this.bgChannelWorker.WorkerSupportsCancellation = true;
            this.bgChannelWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgChannelWorker_DoWork);
            this.bgChannelWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgChannelWorker_ProgressChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.testControls.Controls.Add(this.keysCount);
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
            // keysCount
            // 
            this.keysCount.AutoSize = true;
            this.keysCount.Location = new System.Drawing.Point(431, 14);
            this.keysCount.Name = "keysCount";
            this.keysCount.Size = new System.Drawing.Size(36, 13);
            this.keysCount.TabIndex = 32;
            this.keysCount.Text = "Keys :";
            // 
            // readCount
            // 
            this.readCount.AutoSize = true;
            this.readCount.Location = new System.Drawing.Point(429, 54);
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
            this.columnHeader});
            this.keyList.FullRowSelect = true;
            this.keyList.LabelEdit = true;
            this.keyList.LabelWrap = false;
            this.keyList.Location = new System.Drawing.Point(593, -3);
            this.keyList.Name = "keyList";
            this.keyList.Size = new System.Drawing.Size(188, 562);
            this.keyList.TabIndex = 32;
            this.keyList.UseCompatibleStateImageBehavior = false;
            this.keyList.View = System.Windows.Forms.View.Details;
            this.keyList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyList_KeyDown);
            this.keyList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyList_KeyUp);
            this.keyList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDoubleClick);
            this.keyList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyList_MouseDown);
            this.keyList.Resize += new System.EventHandler(this.keyList_Resize);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.startTimeTxt);
            this.tabPage2.Controls.Add(this.auditReadCount);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lastItemTxt);
            this.tabPage2.Controls.Add(this.auditDelayTxt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.auditLimitTxt);
            this.tabPage2.Controls.Add(this.stopAuditRead);
            this.tabPage2.Controls.Add(this.startAuditRead);
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
            // startTimeTxt
            // 
            this.startTimeTxt.Location = new System.Drawing.Point(85, 6);
            this.startTimeTxt.Name = "startTimeTxt";
            this.startTimeTxt.Size = new System.Drawing.Size(117, 20);
            this.startTimeTxt.TabIndex = 47;
            this.startTimeTxt.Text = "01.01.1970 00:00:00";
            // 
            // auditReadCount
            // 
            this.auditReadCount.AutoSize = true;
            this.auditReadCount.Location = new System.Drawing.Point(529, 31);
            this.auditReadCount.Name = "auditReadCount";
            this.auditReadCount.Size = new System.Drawing.Size(62, 13);
            this.auditReadCount.TabIndex = 45;
            this.auditReadCount.Text = "Read so far";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
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
            // lastItemTxt
            // 
            this.lastItemTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastItemTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastItemTxt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastItemTxt.Location = new System.Drawing.Point(2, 47);
            this.lastItemTxt.Name = "lastItemTxt";
            this.lastItemTxt.Size = new System.Drawing.Size(774, 517);
            this.lastItemTxt.TabIndex = 46;
            this.lastItemTxt.Text = "";
            this.lastItemTxt.WordWrap = false;
            // 
            // auditDelayTxt
            // 
            this.auditDelayTxt.Location = new System.Drawing.Point(336, 6);
            this.auditDelayTxt.Name = "auditDelayTxt";
            this.auditDelayTxt.Size = new System.Drawing.Size(37, 20);
            this.auditDelayTxt.TabIndex = 39;
            this.auditDelayTxt.Text = "0";
            this.auditDelayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // auditLimitTxt
            // 
            this.auditLimitTxt.Location = new System.Drawing.Point(246, 5);
            this.auditLimitTxt.Name = "auditLimitTxt";
            this.auditLimitTxt.Size = new System.Drawing.Size(64, 20);
            this.auditLimitTxt.TabIndex = 37;
            this.auditLimitTxt.Text = "1000";
            // 
            // stopAuditRead
            // 
            this.stopAuditRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopAuditRead.Location = new System.Drawing.Point(701, 0);
            this.stopAuditRead.Name = "stopAuditRead";
            this.stopAuditRead.Size = new System.Drawing.Size(75, 23);
            this.stopAuditRead.TabIndex = 40;
            this.stopAuditRead.Text = "Stop";
            this.stopAuditRead.UseVisualStyleBackColor = true;
            this.stopAuditRead.Click += new System.EventHandler(this.stopAuditRead_Click);
            // 
            // startAuditRead
            // 
            this.startAuditRead.Location = new System.Drawing.Point(3, 3);
            this.startAuditRead.Name = "startAuditRead";
            this.startAuditRead.Size = new System.Drawing.Size(76, 23);
            this.startAuditRead.TabIndex = 38;
            this.startAuditRead.Text = "Start after";
            this.startAuditRead.UseVisualStyleBackColor = true;
            this.startAuditRead.Click += new System.EventHandler(this.startAuditRead_Click);
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
            this.Channel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Channel.Location = new System.Drawing.Point(718, 2);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(66, 20);
            this.Channel.TabIndex = 30;
            this.Channel.Text = "MBSNT";
            // 
            // bgAuditWorker
            // 
            this.bgAuditWorker.WorkerReportsProgress = true;
            this.bgAuditWorker.WorkerSupportsCancellation = true;
            this.bgAuditWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgAuditWorker_DoWork);
            this.bgAuditWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgAuditWorker_ProgressChanged);
            this.bgAuditWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgAuditWorker_RunWorkerCompleted);
            // 
            // bgKeyLoadWorker
            // 
            this.bgKeyLoadWorker.WorkerReportsProgress = true;
            this.bgKeyLoadWorker.WorkerSupportsCancellation = true;
            this.bgKeyLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgKeyLoadWorker_DoWork);
            this.bgKeyLoadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgKeyLoadWorker_ProgressChanged);
            this.bgKeyLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgKeyLoadWorker_RunWorkerCompleted);
            // 
            // ProvDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 614);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "ProvDemo";
            this.Text = "Provisioning Consumer Demo";
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

        private System.ComponentModel.BackgroundWorker bgChannelWorker;
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
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label connStatus;
        private System.Windows.Forms.TextBox startTimeTxt;
        private System.Windows.Forms.Label auditReadCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox lastItemTxt;
        private System.Windows.Forms.TextBox auditDelayTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox auditLimitTxt;
        private System.Windows.Forms.Button stopAuditRead;
        private System.Windows.Forms.Button startAuditRead;
        private System.Windows.Forms.TextBox Channel;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker bgAuditWorker;
        private System.ComponentModel.BackgroundWorker bgKeyLoadWorker;
        private System.Windows.Forms.Label keysCount;
    }
}

