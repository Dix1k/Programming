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
    public partial class Form11 : Form
    {
        private decimal totalSum = 0;
        Thread t;
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открываем вспомогательную форму выбора товара
            using (Form12 selectionForm = new Form12())
            {
                // Показываем форму в модальном режиме
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем выбранные данные
                    string productName = selectionForm.ProductName;
                    decimal productPrice = selectionForm.ProductPrice;

                    // Обновляем список товаров на главной форме
                    listBox1.Items.Add($"{productName} - {productPrice:C}");

                    // Увеличиваем общую сумму
                    totalSum += productPrice;
                    label2.Text = $"Общая сумма: {totalSum:C}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
