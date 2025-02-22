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

namespace Laba_6
{
    public partial class Form1 : Form
    {
        Thread f;
        public Form1()
        {
            InitializeComponent();
            // Устанавливаем сегодняшнюю дату на monthCalendar:
            monthCalendar1.TodayDate = System.DateTime.Now;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar.ToString() == "-" && textBox1.Text == "") || (e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1)) e.Handled = false;
            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d;
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.StartupPath + "..\\..\\..\\..\\..\\meteo.txt");
            System.IO.StreamWriter potok;
            if (fi.Exists) potok = fi.AppendText();
            else potok = fi.CreateText();
            d = monthCalendar1.SelectionStart;
            potok.WriteLine(d.ToShortDateString() + " " + textBox1.Text);
            potok.Close();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenMainForm);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
