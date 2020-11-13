using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Fainshtein
{
    public class Rectangle : CGraphicsObject
    {
        public Rectangle(int x, int y, float width, float length)
        {
            points = new List<Point>();
            points.Add(new Point(x, y));
            this.width = width;
            this.length = length;
        }
        ~Rectangle()
        {

        }

        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Length 
        {
            get { return length; }
            set { length = value; }
        }

        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), points[0].X, points[0].Y, (float)width, (float)length);
        }

        public override void Show(Label label)
        {
            string text = String.Format("Прямоугольник\nКоординаты: {0}\nШирина: {1}, Длина: {2}", points[0], width, length);
            label.Text = text;
        }
        public override string GetClassName()
        {
            return "Rectangle";
        }
        public override double Area() 
        {
            return width * length;
        }
    }
}
