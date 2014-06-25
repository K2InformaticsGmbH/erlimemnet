﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K2Informatics.Erlimemnet;
using System.Threading;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ProvLoadApp
{
    public partial class ProvDemo : Form
    {
        private ImemInterface imeminf = null;
        private bool readAudit = false;
        public ProvDemo()
        {
            InitializeComponent();
        }

        private void getKeys_Click(object sender, EventArgs e)
        {
            keyList.Items.Clear();
            readAudit = tableChoose.SelectedIndex == 0 ? true : false;
            if (readAudit)
            {
                ReadSkvhMFA(Channel.Text, "key", "-1.0e100", int.Parse(LimitTxt.Text), int.Parse(LimitTxt.Text), KeyPatternTxt.Text);
            }
            else // Audit Table access
            {
            }
        }

        private void ReadSkvhMFA(string Channel, string Item, string CKey, int Limit, int More, string keymatchregex)
        {
            if (More > 0)
            {
                // Apply regex and collect untill 1000
                Regex regex = new Regex(keymatchregex, RegexOptions.IgnoreCase);
                ArrayList keys = imeminf.readGT(Channel, Item, CKey, More.ToString());
                foreach (string key in keys)
                {
                    if (regex.Match(key).Success)
                    {
                        keyList.Items.Add(key);
                        Application.DoEvents();
                    }
                }
                if (keys.Count > 0 && More > 0 && keyList.Items.Count < More)
                {
                    string lastKey = (string)keys[keys.Count - 1];
                    ReadSkvhMFA(Channel, Item, lastKey, Limit, Limit - keyList.Items.Count, keymatchregex);
                }
            }
        }

        private void ProvDemo_Load(object sender, EventArgs e)
        {
            testControls.Enabled = false;
            lastValue.Enabled = false;
            keyList.Enabled = false;
            stopBtn.Enabled = false;
            tableChoose.SelectedIndex = 0;
            keyList.Columns[0].Width = keyList.Width - 10;
        }

        private void keyList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (keyList.SelectedItems[0] == null)
            {
                ListViewItem item = keyList.Items.Add(String.Empty);
                item.BeginEdit();
            }
            else
            {
                keyList.SelectedItems[0].BeginEdit();
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            ip.Enabled = false;
            port.Enabled = false;
            ssl.Enabled = false;
            user.Enabled = false;
            password.Enabled = false;
            connectBtn.Enabled = false;
            testControls.Enabled = false;
            lastValue.Enabled = false;
            keyList.Enabled = false;
            connStatus.Text = "";
            Application.DoEvents();
            if (connectBtn.Text == "Connect")
            {
                string ipStr = ip.Text;
                try
                {
                    imeminf = ImemInterface.Connect(ref ipStr, int.Parse(port.Text), ssl.Checked);
                    imeminf.Authenticate(user.Text, password.Text);
                    imeminf.Login();
                    connStatus.ForeColor = Color.Green;
                    connStatus.Text = "Connected";
                    connectBtn.Text = "Disconnect";
                    testControls.Enabled = true;
                    lastValue.Enabled = true;
                    keyList.Enabled = true;
                    startBtn.Enabled = true;
                    stopBtn.Enabled = false;
                    fireDelayMs.Enabled = true;
                }
                catch (Exception ixe)
                {
                    connStatus.ForeColor = Color.IndianRed;
                    connStatus.Text = "Connect Error : " + ixe.Message;
                }
            }
            else // Handle Disconnect
            {
                imeminf = null;
                connectBtn.Text = "Connect";
                ip.Enabled = true;
                port.Enabled = true;
                ssl.Enabled = true;
                user.Enabled = true;
                password.Enabled = true;
                keyList.Items.Clear();
            }
            connectBtn.Enabled = true;
        }

        private void connStatus_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(connStatus.Text);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = true;
            startBtn.Enabled = false;
            fireDelayMs.Enabled = false;
            string[] keys = new string[keyList.Items.Count];
            for (int i = 0; i < keyList.Items.Count; ++i)
                keys[i] = keyList.Items[i].Text;

            backgroundWorker.RunWorkerAsync(new object[] { keys, int.Parse(fireDelayMs.Text) });
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();

            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            fireDelayMs.Enabled = true;
        }


        private long count = 0;
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] keys = (string[])(((object[])e.Argument)[0]);
            int delay = (int)(((object[])e.Argument)[1]);
            BackgroundWorker worker = sender as BackgroundWorker;

            count = 0;
            worker.ReportProgress(0, new string[] { "", "" });
            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    string[] kv = imeminf.readValueRandomKey(keys);
                    count++;
                    if (delay > 1000 || count % 10 == 0) worker.ReportProgress(0, kv);
                    if (delay > 0) Thread.Sleep(delay);
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] kv = (string[])e.UserState;
            readCount.Text = "Read so far " + count.ToString();
            lastKey.Text = kv[0];
            lastValue.Text = kv[1];
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.Print("Work Complete");
        }

        private void keyList_Resize(object sender, EventArgs e)
        {
            keyList.Columns[0].Width = keyList.Width - 10;
        }
    }
}