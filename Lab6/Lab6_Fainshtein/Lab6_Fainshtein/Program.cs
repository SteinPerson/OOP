using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Fainshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            // Треугольник
            Triangle triangle = new Triangle(20, 20, 225, 66, 80, 185);
            Console.WriteLine("=Информация о треугольнике=");
            triangle.Show();
            Console.WriteLine("=Сравнение сторон треугольника=");
            triangle.Comparison();

            Console.WriteLine("====================================");

            // Прямоугольник
            Rectangle rectangle = new Rectangle(160, 160, 40, 50);
            Console.WriteLine("=Информация о прямоугольнике=");
            rectangle.Show();
            Console.WriteLine("=Сравнение сторон прямоугольника=");
            rectangle.Comparison();

            Console.WriteLine("====================================");

            // Коллекция
            ArrayList array = new ArrayList() { triangle, rectangle };
            Console.WriteLine("=Объекты использованные в лабораторной работе=");
            foreach (object elem in array)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
