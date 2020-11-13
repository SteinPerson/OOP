using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_Fainshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'n'; // Выйти ли из программы
            do
            {
                double x = -1; // Неизвестная
                double res; // Результат

                Console.WriteLine("Вас приветствует лаболаторная работа №1");

                do
                {
                    Console.WriteLine("Введите значение неизвестной x в уравнении 1 + (1 + Log10(x))^1/3:");
                    // Запрет ввода не чисел
                    try
                    {
                        x = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вводить можно только цифры! Попробуйте еще раз");
                        Thread.Sleep(1000);
                        continue;
                    }
                    // Запрет ввода отрицательных чисел и 0
                    if (x <= 0)
                    {
                        Console.WriteLine("Число в логарифме не может быть отрицательным или нулевым, попробуйте другое!");
                        Thread.Sleep(1000);
                    }
                } while (x <= 0);

                res = 1 + (Math.Pow(1 + Math.Log10(x), (double)1 / 3));

                Console.WriteLine("Результат равен: " + res); // Вывод результата

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
