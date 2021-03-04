using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtcHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void hack_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            while(true)
            {
                progresm.Maximum = 100;
                progresm.Value = rng.Next(0, 101);
                progress.Text = "PROGRESS: " + (progresm.Value - 14).ToString() + "%";
                for(int i = 0; i < 100000; i++)
                    Application.DoEvents();
                

                if(progresm.Value >= 100)
                {
                    MessageBox.Show("HACKED THE BTCS addded" + amnt.Text+" to btc wallet "+walleeet.Text+" and hacked private key");
                    byte[] btckey = new byte[0x128];
                    rng.NextBytes(btckey);
                    privatKey.Text = BitConverter.ToString(btckey).Replace("-", "");
                    break;
                }

            }
        }
    }
}
