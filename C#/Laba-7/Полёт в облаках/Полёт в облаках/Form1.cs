namespace Полёт_в_облаках
{
    public partial class Form1 : Form
    {
        private System.Drawing.Bitmap sky, plane;
        private Graphics g;
        private int dx;
        private Rectangle rct;
        private System.Random r;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Полёт в облаках";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sky = new Bitmap("..\\..\\..\\..\\sky.bmp");
                plane = new Bitmap("..\\..\\..\\..\\plane.png");
                plane.MakeTransparent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка загрузки битовых образов  \n" + exc.ToString(), "Полёт в облаках", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            BackgroundImage = new Bitmap("..\\..\\..\\..\\sky.bmp");
            this.ClientSize = new System.Drawing.Size(BackgroundImage.Width, BackgroundImage.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            g = Graphics.FromImage(BackgroundImage);
            r = new System.Random();
            rct.X = -40;
            rct.Y = 20 + r.Next(20);
            rct.Width = plane.Width;
            rct.Height = plane.Height;
            dx = 2;
            timer1.Interval = 20;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(sky, 0, 0);
            if (rct.X < this.ClientRectangle.Width) rct.X += dx;
            else
            {
                rct.X = -40;
                rct.Y = 20 + r.Next(this.ClientSize.Height - 40 - plane.Height);
                dx = 2 + r.Next(5);
            }
            g.DrawImage(plane, rct.X, rct.Y);
            Rectangle rct2 = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
            g.DrawRectangle(Pens.Black, rct2.X, rct2.Y, rct2.Width - 1, rct2.Height - 1);
            this.Invalidate(rct2);
        }
    }
}
