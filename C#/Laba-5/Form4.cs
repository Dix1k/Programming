using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class Form4 : Form
    {
        Thread f;
        public Form4()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        { // Каталог выбран? Помещаем его имя в textBox1:
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear(); // Очищаем компонент
                                     // Имя исходного каталога берем из textBox1:
            string DirRoot = textBox1.Text;
            if (!Directory.Exists(DirRoot))
                MessageBox.Show("Каталог " + DirRoot + " не найден!", "Внимание");
            else
            { // Начинаем наполнение:
                treeView1.BeginUpdate();
                // Создаем новый узел:
                TreeNode TN = new TreeNode(DirRoot);
                //Вызываем процедуру рекурсивного обхода:
                ProcessDirectory(DirRoot, TN);
                treeView1.Nodes.Add(TN); // Добавляем узел
                treeView1.Nodes[0].Expand();//Раскрываем его
                treeView1.Select(); // Выбираем его
                treeView1.EndUpdate();//Завершаем наполнение
                label1.Text = "";
            }
        }
        private void ProcessDirectory(string Dir, TreeNode Node)
        // Dir – текущий каталог, Node-новый пустой узел
        {
            string[] SubDir; // Массив для имен подкаталогов
                             // Заполняем этот массив
            SubDir = Directory.GetDirectories(Dir);
            // Просматриваем все подкаталоги:
            foreach (string SB in SubDir)
            {// Показываем имя текущего каталога
                label1.Text = SB;
                // Приостанавливаем до прорисовки
                Application.DoEvents();
                // Создаем узел
                TreeNode tempNode = new TreeNode(SB);
                // Рекурсивно все повторяем
                ProcessDirectory(SB, tempNode);
                // Добавляем узел
                Node.Nodes.Add(tempNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            string[] FileList; // Массив имен файлов
            // Наполняем массив:
            FileList = Directory.GetFiles(treeView1.SelectedNode.Text);
            // Помещаем имена в список ListBox:
            foreach (string fileName in FileList)
                listBox1.Items.Add((Path.GetFileName(fileName)).ToLower());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти ? " , "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                f = new Thread(OpenMainForm);
                f.SetApartmentState(ApartmentState.STA);
                f.Start();
            }
        }
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
