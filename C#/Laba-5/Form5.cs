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

namespace Laba_5
{
    public partial class Form5 : Form
    {
        Thread f;
        public Form5()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            // Очистить TreeView
            treeView1.Nodes.Clear();

            // Создать корневые узлы (тип данных)
            var rootNode = new TreeNode("Типы данных C#");
            treeView1.Nodes.Add(rootNode);

            // Добавить дочерние узлы (примеры типов данных)
            AddChild(rootNode, "Простые типы");
            AddChild(rootNode, "Ссылочные типы");
            AddChild(rootNode, "Структуры");
            AddChild(rootNode, "Массивы");
            AddChild(rootNode, "Перечисления");

            // Развернуть узлы
            treeView1.ExpandAll();
        }

        private void AddChild(TreeNode parentNode, string childName)
        {
            parentNode.Nodes.Add(new TreeNode(childName));
        }

        private void button1_Click(object sender, EventArgs e)
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

