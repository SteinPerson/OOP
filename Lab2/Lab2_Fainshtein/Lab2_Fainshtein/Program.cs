using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2_Fainshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'n'; // Выйти ли из программы

            do
            {
                bool ifCorrect = true; // Правильно ли введено число
                double ellipseArea;
                double bigSAxis = 0, smallSAxis = 0;
                Ellipse ellipse = new Ellipse();

                // Задавание размеров
                do
                {
                    try
                    {
                        ifCorrect = true;
                        Console.WriteLine("Введите рамзер большей полуоси:");
                        bigSAxis = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите рамзер меньшей полуоси:");
                        smallSAxis = Convert.ToDouble(Console.ReadLine());
                    } catch (FormatException)
                    {
                        ifCorrect = false;
                        Console.WriteLine("Вводить можно только цифры! Попробуйте еще раз");
                        Thread.Sleep(1000);
                        continue;
                    }
                } while (!ifCorrect);

                ellipse.set_bigSemiAxis(bigSAxis);
                ellipse.set_smallSemiAxis(smallSAxis);
                ellipseArea = ellipse.Area(); // Площадь

                Console.WriteLine("Площадь эллипса: " + ellipseArea);

                // Выйти ли
                do
                {
                    Console.WriteLine("Если хотите выйти из программы напишите \"y\", если нет, то \"n\"");
                    // Запрет ввода не букв
                    try
                    {
                        exit = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильно введено значение! Попробуйте еще раз");
                        Thread.Sleep(1000);
                        exit = 'q';
                        continue;
                    }
                    // Запрет ввода не латинских y и n
                    if (exit != 'n' && exit != 'y')
                    {
                        Console.WriteLine("Неправильно введено значение! Попробуйте еще раз");
                        Thread.Sleep(1000);
                    }
                } while (exit != 'n' && exit != 'y');

            } while (exit == 'n'); // Выход из программы при значении 'y'
        }
    }
}
