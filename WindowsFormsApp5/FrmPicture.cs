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
    public partial class FrmPicture : Form
    {
        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
     
        public FrmPicture()
        {
            InitializeComponent();
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;

            graphicsObj3 = this.picTry.CreateGraphics();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:/Users/LENOVO/Desktop/DpS21LLUYAI15At.jpg");

            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {
            Point coordinates = picTry.PointToClient(Cursor.Position); //relative to Panel control

            //MessageBox.Show("Coordinates are: " + coordinates);

            graphicsObj3.DrawLine(myPen, coordinates.X - 1, coordinates.Y - 1, coordinates.X, coordinates.Y);
        }
    }
}
