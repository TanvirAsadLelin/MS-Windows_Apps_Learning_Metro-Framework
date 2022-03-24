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

namespace MetroFramework_MessageBox
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroBtnClickMe_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Welcome " + metroTextBoxName.Text , "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTileOk_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "OK", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroTileYesNo_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Yes No", "Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void metroTileError_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Error", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void metroTileNone_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "None", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void metroTileYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Yes No Cancel", "Welcome", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                MetroFramework.MetroMessageBox.Show(this, "You have successfuly done!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr == DialogResult.No)
            {
                MetroFramework.MetroMessageBox.Show(this, "You are not agree!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "You cancel the operation", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroTileWarning_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Warning", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroTileStop_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Stop", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
