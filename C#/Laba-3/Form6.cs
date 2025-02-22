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
    public partial class Form6 : Form
    {
        public double k1, k2;

        Thread t;
        public Form6()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form6_Activated(object sender, EventArgs e)
        {
            операцияToolStripMenuItem.Enabled = false;
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Сумма равна " + Convert.ToString(k1 + k2);
        }

        private void разностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Разность равна" + Convert.ToString(k1 - k2);
        }

        private void произведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Произведение равно" + Convert.ToString(k1 * k2);
        }

        private void частноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k2 != 0)
                label1.Text = "Частное равно" + Convert.ToString(k1 / k2);
            else label1.Text = "На ноль делить нельзя!";
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

        private void информацияОРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }


        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
            k1 = f7.a;
            k2 = f7.b;
            //После внесеня данных делаем доступным пункт Операция:
            операцияToolStripMenuItem.Enabled = true;
        }

    }
}
