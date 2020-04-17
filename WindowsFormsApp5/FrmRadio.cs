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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");

            rdoRed2.Checked = false;
            rdoGreen2.Checked = false;
            rdoBlue2.Checked = false;
            rdoYellow2.Checked = false;

            rdoRed2.ForeColor = Color.FromName("black");
            rdoGreen2.ForeColor = Color.FromName("black");
            rdoBlue2.ForeColor = Color.FromName("black");
            rdoYellow2.ForeColor = Color.FromName("black");
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked == true)
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0); // http://www.flounder.com/csharp_color_table.htm
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            rdoRed2.ForeColor = Color.FromName("red");
        }

        private void rdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            rdoGreen2.ForeColor = Color.FromName("green");
        }

        private void rdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void rdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow2.ForeColor = Color.FromName("yellow");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
