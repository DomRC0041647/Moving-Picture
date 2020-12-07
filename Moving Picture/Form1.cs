using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            }
                
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < ClientRectangle.Width)
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < ClientRectangle.Height)
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }      
}
