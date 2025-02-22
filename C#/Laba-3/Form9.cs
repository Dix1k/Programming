using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Form9 : Form
    {
        Thread t;
        public Form9()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 0;
            trackBar1.Value = 50;
            trackBar1.TickFrequency = 10;
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 0;
            trackBar2.Value = 50;
            trackBar2.TickFrequency = 10;
            label1.Text = "";
            label2.Text = "";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            float a;

            a = pictureBox1.Image.PhysicalDimension.Width;
            label1.Text = Convert.ToString(trackBar1.Value) + "%";
            pictureBox1.Width = (Int16)(a / 50 * trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float b;

            b = pictureBox1.Image.PhysicalDimension.Height;
            label2.Text = Convert.ToString(100 - trackBar2.Value) + "%";
            pictureBox1.Height = 1400 - (Int16)(b / 50 * trackBar2.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart(object obj)
        {
            Application.Run(new Main());
        }
    }
}

