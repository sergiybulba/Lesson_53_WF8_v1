namespace Lesson_53_WF_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Znak = e.Graphics;
            Znak.Clear(Color.Silver);

            Pen pen = new Pen(Color.Black, 3);      // контур - чорне коло
            Rectangle circle = new Rectangle(150, 25, 400, 400);
            Znak.DrawEllipse(pen, circle);

            Brush brush = new SolidBrush(Color.White);  // біла заливка всередині кола
            Znak.FillEllipse(brush, circle);

            circle = new Rectangle(160, 35, 380, 380);  // червона заливка всередині кола
            brush = new SolidBrush(Color.Red);
            Znak.FillEllipse(brush, circle);

            Rectangle rectangle = new Rectangle(200, 185, 300, 80);  // білий прямокутник всередині кола
            brush = new SolidBrush(Color.White);
            Znak.FillRectangle(brush, rectangle);

        }
    }
}