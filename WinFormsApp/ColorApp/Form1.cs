using System.Drawing;
using System.Windows.Forms;

namespace ColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            Pen pen = new Pen(Color.DeepPink);
            pen.Width = 5.0f;
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //Point starPoint = new Point(45, 45);
            //Point endPoint = new Point(180, 150);
            //g.DrawLine(pen, starPoint, endPoint);
            //g.DrawLine(pen, 190, 60, 65, 170);

            //Rectangle rect = new Rectangle(50, 50, 150, 100);
            Rectangle[] rect = new Rectangle[]
            {
                new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40)
            };
            g.FillRectangles(Brushes.BlueViolet, rect);
            g.DrawRectangles(pen, rect);

            Point[] pts =
            {
                new Point(515, 30), new Point(540, 90),
                new Point(600, 115), new Point(540, 140),
                new Point(515, 200), new Point(490, 140),
                new Point(430, 115), new Point(490, 90)
            };
            g.FillClosedCurve(Brushes.YellowGreen, pts);
            g.DrawClosedCurve(pen, pts);
        }
    }
}
