using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Form12 : Form
    {
        public string ProductName;
        public decimal ProductPrice;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем введенные данные
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !decimal.TryParse(textBox2.Text, out decimal price))
            {
                MessageBox.Show("Введите корректные данные о товаре.");
                return;
            }

            // Устанавливаем свойства
            ProductName = textBox1.Text;
            ProductPrice = price;

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
