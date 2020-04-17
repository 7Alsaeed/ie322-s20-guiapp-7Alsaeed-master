using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmRandomC : Form
    {
        public FrmRandomC()
        {
            InitializeComponent();
        }

        private void CmbRandom_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CmbRandom.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoLess.Checked = true;
            }
         
            }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbRandom.Items.Add(r.Next(100, 999));
            }
        }

        private void rdoGreater_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();
            rdoLess.Checked = false;
            rdoGreater.Checked = false;
        }

        private void CmbRandom2_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CmbRandom2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }
        }

        private void btnGenerateRandom2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                CmbRandom2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(CmbRandom2.Items.Count);
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            CmbRandom2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
            label1.Text = Convert.ToString(CmbRandom2.Items.Count);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
