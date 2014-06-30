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
        private const String imemintflock = "imemintflock";
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
            keysCount.Text = "Keys : ";
            bgKeyLoadWorker.RunWorkerAsync(new object[] { Channel.Text, "key", "-1.0e100", int.Parse(LimitTxt.Text), KeyPatternTxt.Text });
            getKeys.Enabled = false;
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
                    lock (imemintflock)
                    {
                        imeminf.Authenticate(user.Text, password.Text);
                        imeminf.Login();
                    }
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
                lock (imemintflock) { imeminf = null; }
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
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            bgChannelWorker.CancelAsync();

            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            fireDelayMs.Enabled = true;
            count = 0;
        }

        private long count = 0;
        private void bgChannelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] keys = (string[])(((object[])e.Argument)[0]);
            int delay = (int)(((object[])e.Argument)[1]);
            BackgroundWorker worker = sender as BackgroundWorker;

            count = 0;
            startedat = DateTime.Now;
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
                    string[] kv;
                    try
                    {
                        lock (imemintflock) { if (imeminf == null) break; kv = imeminf.readValueRandomKey(keys); }
                        count++;
                        if ((DateTime.Now - start).TotalMilliseconds > 500)
                        {
                            start = DateTime.Now;
                            try { worker.ReportProgress(0, kv); }
                            catch (Exception) { }
                        }
                        if (delay > 0) Thread.Sleep(delay);
                    }
                    catch (Exception ex)
                    {
                        worker.ReportProgress(0, ex);
                        break;
                    }
                }
            }
        }

        private string origText = "";
        private void bgChannelWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Exception)
            {
                MessageBox.Show(((Exception)e.UserState).Message + "\n" + ((Exception)e.UserState).StackTrace);
            }
            else
            {
                string[] kv = (string[])e.UserState;
                double rate = count / (double)(DateTime.Now - startedat).TotalSeconds;
                readCount.Text = "Read so far " + count.ToString() + " @ " + rate.ToString("0.##/sec");
                lastKey.Text = kv[0];
                origText = kv[1];
                lastValue.Text = origText;
            }
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
            bgAuditWorker.RunWorkerAsync(new object[] { Channel.Text, startTimeTxt.Text, auditLimitTxt.Text, int.Parse(auditDelayTxt.Text) });
            startedat = DateTime.Now;
            startAuditRead.Enabled = false;
            stopAuditRead.Enabled = true;
        }

        private long auditcount = 0;
        private DateTime auditstartedat;
        private void bgAuditWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string channel = (string)(((object[])e.Argument)[0]);
            string startTime = (string)(((object[])e.Argument)[1]);
            string limit = (string)(((object[])e.Argument)[2]);
            int delay = (int)(((object[])e.Argument)[3]);
            auditcount = 0;
            auditstartedat = DateTime.Now;
            DateTime start = DateTime.Now;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0, "");

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    object[] res;
                    try
                    {
                        lock (imemintflock) { if (imeminf == null) break; res = imeminf.audit_readGT(channel, "tkvuquadruple", startTime, limit); }
                        auditcount += res.Length;
                        foreach (OtpErlangBinary item in res)
                        {
                            auditcount++;
                            if (((DateTime.Now - start).TotalMilliseconds > 500 || auditcount % 100 == 0) && res.Length > 0)
                            {
                                start = DateTime.Now;
                                try { worker.ReportProgress(0, item.stringValue()); }
                                catch (Exception) { }
                            }
                        }
                        if (res.Length > 0)
                            startTime = ((OtpErlangBinary)res[res.Length - 1]).stringValue().Split(new char[] { '\t' })[0];
                        if (delay > 0) Thread.Sleep(delay);
                    }
                    catch (Exception ex)
                    {
                        worker.ReportProgress(0, ex);
                        break;
                    }
                }
            }
        }

        private void bgAuditWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Exception)
            {
                MessageBox.Show(((Exception)e.UserState).Message + "\n" + ((Exception)e.UserState).StackTrace);
            }
            else
            {
                string audit = (string)e.UserState;
                double rate = auditcount / (double)(DateTime.Now - auditstartedat).TotalSeconds;
                auditReadCount.Text = "Read so far " + auditcount.ToString() + " @ " + rate.ToString("0.##/sec");
                lastItemTxt.Text = string.Join("\r\n----\r\n", audit.Split(new char[] { '\t' }));
            }
        }

        private void stopAuditRead_Click(object sender, EventArgs e)
        {
            bgAuditWorker.CancelAsync();
            startAuditRead.Enabled = true;
            stopAuditRead.Enabled = false;
        }

        private Queue keysQ = new Queue();
        private void bgKeyLoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string Channel = (string)(((object[])e.Argument)[0]);
            string Item = (string)(((object[])e.Argument)[1]);
            string CKey = (string)(((object[])e.Argument)[2]);
            int Limit = (int)(((object[])e.Argument)[3]);
            string keymatchregex = (string)(((object[])e.Argument)[4]);
            int More = Limit;
            BackgroundWorker worker = sender as BackgroundWorker;
            DateTime start = DateTime.Now;
            while (More > 0)
            {
                // Apply regex and collect untill 1000
                Regex regex = new Regex(keymatchregex, RegexOptions.IgnoreCase);
                object[] keys;
                try
                {
                    lock (imemintflock) { if (imeminf == null) break; keys = imeminf.readGT(Channel, Item, CKey, More.ToString()); }
                    foreach (OtpErlangBinary key in keys)
                    {
                        string kstr = key.stringValue();
                        if (regex.Match(kstr).Success)
                        {
                            lock (keysQ) { keysQ.Enqueue(kstr); }
                        }
                    }
                    if (keys.Length > 0 && More > 0 && keysQ.Count < Limit)
                    {
                        string lastKey = ((OtpErlangBinary)keys[keys.Length - 1]).stringValue();
                        CKey = lastKey;
                        More = Limit - keysQ.Count;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    worker.ReportProgress(0, ex);
                    break;
                }
                if ((DateTime.Now - start).TotalMilliseconds > 500 || keysQ.Count > 500)
                {
                    start = DateTime.Now;
                    try { worker.ReportProgress(0, "update"); }
                    catch (Exception) { }
                }
            }
            try { worker.ReportProgress(0, "complete"); }
            catch (Exception) { }
        }

        private void bgKeyLoadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Exception)
            {
                MessageBox.Show(((Exception)e.UserState).Message + "\n" + ((Exception)e.UserState).StackTrace);
            }
            else
            {
                while (keysQ.Count > 0)
                {
                    lock (keysQ) { keyList.Items.Add((string)keysQ.Dequeue()); }
                    if (keyList.Items.Count % 1000 == 0)
                    {
                        keyList.Items[keyList.Items.Count - 1].EnsureVisible();
                        keysCount.Text = "Keys : " + keyList.Items.Count;
                        Application.DoEvents();
                    }
                }
                if (e.UserState is string && ((string)e.UserState) == "complete")
                {
                    keyList.Items[keyList.Items.Count - 1].EnsureVisible();
                    keysCount.Text = "Keys : " + keyList.Items.Count;
                }
            }
        }

        private void bgKeyLoadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            getKeys.Enabled = true;
        }

        private void bgAuditWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startAuditRead.Enabled = true;
        }

        private void keyList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.A | Keys.Control))
            {
                foreach (ListViewItem item in keyList.Items)
                    item.Selected = true;
            }
            else if (e.KeyData == (Keys.C | Keys.Control))
            {
                StringBuilder sb = new StringBuilder(); 
                foreach (ListViewItem item in keyList.SelectedItems)
                {
                    sb.Append(item.Text);
                    sb.Append("\r\n");
                }
                Clipboard.SetText(sb.ToString());
            }
        }
    }
}