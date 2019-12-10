using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework_10_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = 
        }

        OpenFileDialog ofd = new OpenFileDialog();
       
        private void Button1_Click(object sender, EventArgs e)
        {
            
            ofd.Title = "Select your image";

            

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image;
            }
        }
    }
}
