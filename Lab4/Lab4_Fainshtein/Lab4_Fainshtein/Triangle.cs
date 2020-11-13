using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Lab4_Fainshtein
{
    public class Triangle : CGraphicsObject
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            points = new List<Point>();
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));
            points.Add(new Point(x3, y3));
        }
        ~Triangle()
        {
            
        }

        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        public override void Draw(PaintEventArgs e)
        {
            Point[] PointsArr = new Point[3];
            for (int i = 0; i < 3; i++)
                PointsArr[i] = points[i];
            e.Graphics.DrawPolygon(new Pen(Color.Black), PointsArr);
        }

        public override void Show(Label label)
        {
            string text = string.Format("Треугольник\nКоординаты:\n{0}\n{1}\n{2}", points[0], points[1], points[2]);
            label.Text = text;
        }
        public override string GetClassName()
        {
            return "Triangle";
        }
        public override double Area()
        {
            double side1 = Sqrt(Pow(points[1].X - points[0].X, 2) + Pow(points[1].Y - points[0].Y, 2));
            double side2 = Sqrt(Pow(points[1].X - points[2].X, 2) + Pow(points[1].Y - points[2].Y, 2));
            double side3 = Sqrt(Pow(points[2].X - points[0].X, 2) + Pow(points[2].Y - points[0].Y, 2));
            double p = (side1 + side2 + side3) / 2;
            double S = Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return S;
        }
    }
}
