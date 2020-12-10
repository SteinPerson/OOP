using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6_Fainshtein
{
    interface ITrianleArea // Интерфейс
    {
        double Area();
    }

    delegate void TriangleComparison(); // Делегат

    class Triangle : CGraphicsObject, ITrianleArea
    {
        TriangleComparison triangleComparison;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) // Конструктор
        {
            points = new List<Point>();
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));
            points.Add(new Point(x3, y3));
            this.side1 = Sqrt(Pow(points[1].X - points[0].X, 2) + Pow(points[1].Y - points[0].Y, 2));
            this.side2 = Sqrt(Pow(points[1].X - points[2].X, 2) + Pow(points[1].Y - points[2].Y, 2));
            this.side3 = Sqrt(Pow(points[2].X - points[0].X, 2) + Pow(points[2].Y - points[0].Y, 2));
        }
        ~Triangle() // Деструктор
        {

        }

        //Геттеры и сеттеры
        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        public double Side1 
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        public override void Show()
        {
            string text = string.Format("Треугольник\nКоординаты:\n{0}\n{1}\n{2}\nСтороны:\nПервая сторона: {3}\nВторая сторона: {4}\nТретья сторона: {5}", points[0], points[1], points[2], side1, side2, side3);
            Console.WriteLine(text);
        }

        // Сравнение сторон
        public void Comparison()
        {
            if (this.side1 > this.side2 && this.side1 > this.side3)
            {
                triangleComparison = FirstSideIsBigger;
            }
            else if (this.side2 > this.side1  && this.side2 > this.side3)
            {
                triangleComparison = SecondSideIsBigger;
            }
            else if (this.side3 > this.side1 && this.side3 > this.side2)
            {
                triangleComparison = ThirdSideIsBigger;
            }
            triangleComparison();
        }

        public void FirstSideIsBigger()
        {
            Console.WriteLine("Первая сторона больше");
        }

        public void SecondSideIsBigger()
        {
            Console.WriteLine("Вторая сторона больше");
        }

        public void ThirdSideIsBigger()
        {
            Console.WriteLine("Третья сторона больше");
        }

        // Площадь
        public double Area()
        {
            double p = (side1 + side2 + side3) / 2;
            double S = Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return S;
        }
    }
}
