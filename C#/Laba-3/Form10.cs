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
    public partial class Form10 : Form
    {
        Thread t;
        public Form10()
        {
            InitializeComponent();
        }

        private void крупныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 15);
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12);
        }

        private void мелкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 8);
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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
