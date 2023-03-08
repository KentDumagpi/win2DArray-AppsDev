using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap("C:\\Users\\QQ111\\Downloads\\images.jfif");

            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int avg = (r + g + b) / 3;
                    bt.SetPixel(x, y, Color.FromArgb(avg, avg, avg));


                }
            }
            pictureBox2.Image = bt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var color = new Bitmap("C:\\Users\\QQ111\\Downloads\\images.jfif");
            var bw = color.Clone(new Rectangle(0,0 ,color.Width, color.Height), PixelFormat.Format1bppIndexed);
            pictureBox3.Image = bw;
        }
        
    }
}


