using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using K2Informatics.Erlimemnet;

namespace WindowsFormsApplication1
{
    public partial class ProvDemo : Form
    {
        private ImemInterface imeminf = null;
        public ProvDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Apply regex and collect untill 1000
            ReadSkvhMFA("chn", "key", "-1.0e100", "10000");
        }

        private String[] ReadSkvhMFA(String Channel, String Item, String CKey, String Limit)
        {
            return new String[] { "String0", "String1", "String2" };
        }

        private void ProvDemo_Load(object sender, EventArgs e)
        {
            keyList.Items.Add("1");
            keyList.Items.Add("2");
            keyList.Items.Add("3");
            keyList.Items.Add("4");
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
                }
                catch (Exception ixe)
                {
                    connStatus.ForeColor = Color.IndianRed;
                    connStatus.Text = "Connect Error : " + ixe.Message;
                }
            }
            else // Handle Disconnect
            {
            }
        }
    }
}