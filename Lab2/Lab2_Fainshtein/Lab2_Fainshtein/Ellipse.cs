using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab2_Fainshtein
{
    class Ellipse
    {
        double smallSemiAxis, bigSemiAxis;

        // Конструктор
        public Ellipse()
        {
            smallSemiAxis = 10;
            bigSemiAxis = 20;
        }

        // Деструктор
        ~Ellipse()
        {
            Console.WriteLine("Эллипс удален");
        }

        // Площадь
        public double Area()
        {
            double area;
            area = PI * smallSemiAxis * bigSemiAxis;
            return area;
        }

        // Геттеры и Сеттеры
        public void set_smallSemiAxis(double sA)
        {
            smallSemiAxis = sA;
        }
        public void set_bigSemiAxis(double sB)
        {
            bigSemiAxis = sB;
        }
        public double get_smallSemiAxis()
        {
            return smallSemiAxis;
        }
        public double get_bigSemiAxis()
        {
            return bigSemiAxis;
        }
    }
}
