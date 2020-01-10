using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;


namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mat scr = new Mat(@"C:\Users\lin\Desktop\image\lena.jpg", LoadImageType.AnyColor);
            Mat dst = new Mat();
            //CvInvoke.Resize(scr, dst, new Size(150, 200), 0, 0, Inter.Cubic);//三次样条插值
            CvInvoke.Resize(scr, dst, new Size(150, 200), 0, 0, Inter.Lanczos4);//兰索斯算法插值

            label1.Text = "size:" + scr.Size.ToString();
            label2.Text = "size:" + dst.Size.ToString();
            imageBox1.Image = scr;
            imageBox2.Image = dst;

        }
    }
}
