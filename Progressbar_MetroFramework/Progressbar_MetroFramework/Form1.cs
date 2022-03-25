using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;

namespace Progressbar_MetroFramework
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar.Increment(1);
            int value = metroProgressBar.Value;

            metroLabel.Text = "Progressing..." + value + "%";
            metroLabel.Visible = true;
            
            if(metroProgressBar.Value == 100)
            {
                timer1.Stop();
                metroLabel.Text = "Done";
                Welcome welcome = new Welcome();

                this.Hide();
                welcome.Show();
                

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

          
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
