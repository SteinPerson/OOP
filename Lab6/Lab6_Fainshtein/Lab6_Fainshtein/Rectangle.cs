using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Fainshtein
{
    interface IRectangleArea // Интерфейс
    {
        double Area();
    }

    delegate void RectangleComparison(); // Делегат

    class Rectangle : CGraphicsObject, IRectangleArea
    {
        RectangleComparison rectangleComparison;

        public Rectangle(int x, int y, float width, float length) // Конструктор
        {
            points = new List<Point>();
            points.Add(new Point(x, y));
            this.width = width;
            this.length = length;
        }
        ~Rectangle() // Деструктор
        {

        }

        // Геттеры и сеттеры
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

        // Площадь
        public double Area()
        {
            return width * length;
        }

        public override void Show()
        {
            string text = String.Format("Прямоугольник\nКоординаты: {0}\nШирина: {1}, Длина: {2}", points[0], width, length);
            Console.WriteLine(text);
        }

        // Сравнение сторон
        public void Comparison()
        {
            if (this.width > this.length)
            {
                rectangleComparison = WidthIsBigger;
            } else if (this.width < this.length)
            {
                rectangleComparison = LengthIsBigger;
            }
            rectangleComparison();
        }

        public void WidthIsBigger()
        {
            Console.WriteLine("Ширина больше");
        }

        public void LengthIsBigger()
        {
            Console.WriteLine("Длина больше");
        }
    }
}
