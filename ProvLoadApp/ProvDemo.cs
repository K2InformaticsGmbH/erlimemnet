using System;
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
using K2Informatics.Erlnet;

namespace ProvLoadApp
{
    public partial class ProvDemo : Form
    {
        private ImemInterface imeminf = null;
        public ProvDemo()
        {
            InitializeComponent();
        }

        private void ProvDemo_Load(object sender, EventArgs e)
        {
            testControls.Enabled = false;
            lastValue.Enabled = false;
            keyList.Enabled = false;
            stopBtn.Enabled = false;
            keyList.Columns[0].Width = keyList.Width - 10;
            connStatus.Text = "";

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(connStatus, "Click to see error details");
            toolTip.SetToolTip(lastValue, "DoubleClick to toggle between flat and pretty view");
            toolTip.SetToolTip(keyList, "DoubleClick: Edit entry, Del: Delete, DoubleClick on empty line: Enter New");
        }

        private void getKeys_Click(object sender, EventArgs e)
        {
            keyList.Items.Clear();
            ReadSkvhMFA(Channel.Text, "key", "-1.0e100", int.Parse(LimitTxt.Text), int.Parse(LimitTxt.Text), KeyPatternTxt.Text);
        }

        private void ReadSkvhMFA(string Channel, string Item, string CKey, int Limit, int More, string keymatchregex)
        {
            if (More > 0)
            {
                // Apply regex and collect untill 1000
                Regex regex = new Regex(keymatchregex, RegexOptions.IgnoreCase);
                object[] keys = imeminf.readGT(Channel, Item, CKey, More.ToString());
                foreach (OtpErlangBinary key in keys)
                {
                    string kstr = key.stringValue();
                    if (regex.Match(kstr).Success)
                    {
                        keyList.Items.Add(kstr);
                        Application.DoEvents();
                    }
                }
                if (keys.Length > 0 && More > 0 && keyList.Items.Count < More)
                {
                    string lastKey = ((OtpErlangBinary)keys[keys.Length - 1]).stringValue();
                    ReadSkvhMFA(Channel, Item, lastKey, Limit, Limit - keyList.Items.Count, keymatchregex);
                }
            }
        }

        private void keyList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (keyList.SelectedItems.Count <= 0)
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

        private DateTime startedat;
        private void startBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = true;
            startBtn.Enabled = false;
            fireDelayMs.Enabled = false;
            List<string> keys = new List<string>();
            foreach (ListViewItem lvi in keyList.Items)
                if (lvi.Text.Length > 0) keys.Add(lvi.Text);

            bgChannelWorker.RunWorkerAsync(new object[] { keys.ToArray(), int.Parse(fireDelayMs.Text) });
            startedat = DateTime.Now;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            bgChannelWorker.CancelAsync();

            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            fireDelayMs.Enabled = true;
        }

        private long count = 0;
        private void bgChannelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] keys = (string[])(((object[])e.Argument)[0]);
            int delay = (int)(((object[])e.Argument)[1]);
            BackgroundWorker worker = sender as BackgroundWorker;

            count = 0;
            worker.ReportProgress(0, new string[] { "", "" });
            DateTime start = DateTime.Now;
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
                    if ((DateTime.Now - start).TotalMilliseconds > 500)
                    {
                        start = DateTime.Now;
                        try { worker.ReportProgress(0, kv); }
                        catch (Exception) { }
                    }
                    if (delay > 0) Thread.Sleep(delay);
                }
            }
        }

        private string origText = "";
        private void bgChannelWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] kv = (string[])e.UserState;
            double rate = count / (double)(DateTime.Now - startedat).Seconds;
            readCount.Text = "Read so far " + count.ToString() + " @ " + rate.ToString("0.##/sec");
            lastKey.Text = kv[0];
            origText = kv[1];
            lastValue.Text = origText;
        }

        private void bgChannelWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.Print("Work Complete");
        }

        private void keyList_Resize(object sender, EventArgs e)
        {
            keyList.Columns[0].Width = keyList.Width - 10;
        }

        private void keyList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
                keyList_MouseDoubleClick(sender, e);
        }

        private bool isRtf = false;
        private void lastValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isRtf)
            {
                lastValue.WordWrap = false;
                lastValue.ScrollBars = RichTextBoxScrollBars.Both;
                try { lastValue.Rtf = Json.FormatJson(origText); }
                catch (Exception) { lastValue.Rtf = ""; lastValue.Text = origText; }
            }
            else
            {
                lastValue.WordWrap = true;
                lastValue.ScrollBars = RichTextBoxScrollBars.Vertical;
                lastValue.Rtf = "";
                lastValue.Text = origText;
            }
            isRtf = !isRtf;
        }

        private void keyList_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyList.SelectedItems.Count > 0 && e.KeyCode == Keys.Delete)
            {
                int count = keyList.SelectedItems.Count;
                if (count == 1)
                {
                    var idx = keyList.SelectedItems[0].Index;
                    keyList.SelectedIndices.Add(idx);
                }

                foreach (ListViewItem lvi in keyList.SelectedItems)
                    keyList.Items.Remove(lvi);
                if (keyList.Items.Count > 0 && count > 1)
                        keyList.Items[0].Selected = true;
            }
        }

        private void startAuditRead_Click(object sender, EventArgs e)
        {
            bgAuditWorker.RunWorkerAsync(new object[] { Channel.Text, startTimeTxt.Text, auditLimitTxt.Text, int.Parse()                       });
            startedat = DateTime.Now;
        }

        private void bgAuditWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] res = imeminf.audit_readGT(Channel.Text, "tkvuquadruple", startTimeTxt.Text, auditLimitTxt.Text);
            foreach (OtpErlangBinary item in res)
            {
                lastItemTxt.Text = item.stringValue();
            }
        }

        private void bgAuditWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgAuditWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}