using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.CannySobelEdgeDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dOpen.ShowDialog() == DialogResult.OK)
            {
                filePath = dOpen.FileName;
                pictureBox1.Image = new Bitmap(dOpen.OpenFile());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sobel sobel = new Sobel();
            sobel.SobelEdgeDetection(pictureBox1, pictureBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int threshold = Convert.ToInt16(textBox1.Text);
            Canny canny = new Canny();
            canny.CannyEdgeDetection(threshold, pictureBox1, pictureBox2);
        }
    }
}
