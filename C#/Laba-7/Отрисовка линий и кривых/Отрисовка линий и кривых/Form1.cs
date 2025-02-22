namespace Отрисовка_линий_и_кривых
{
    public partial class Form1 : Form
    {
        public Point[] Points = new Point[10];
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Отрисовка линий и кривых";
            this.ClientSize = new System.Drawing.Size(450, 400);
            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnCount = 11;
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Width = 300;
            dataGridView1.Rows[0].Cells[0].Value = "x";
            dataGridView1.Rows[1].Cells[0].Value = "y";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 20, y = 20;
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                Points[i] = new Point(x, y);
                x += 50;
                y = r.Next(300);
                dataGridView1.Rows[0].Cells[i + 1].Value = x.ToString();
                dataGridView1.Rows[1].Cells[i + 1].Value = y.ToString();
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                Pen P = new Pen(Color.Blue, 2);
                e.Graphics.DrawCurve(P, Points);
                Pen p = new Pen(Color.Red, 2);
                e.Graphics.DrawLines(p, Points);
        }
    }
}
