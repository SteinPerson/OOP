using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_Fainshtein1
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'n'; // Выйти ли из программы
            do
            {
                Action action = new Action();
                int menu = 0;
                Console.WriteLine("Выберите сущность[1/2]:");
                Console.WriteLine("1. Конь\n2. Человек");

                // Проверка на правильность ввода
                do
                {
                    try
                    {
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException) // Запрет ввода не чисел
                    {
                        Console.WriteLine("Вводить можно только цифры! Попробуйте еще раз");
                        Console.WriteLine("Выберите сущность[1/2]:");
                        continue;
                    }
                    if (menu <= 0 || menu >= 3)
                    {
                        Console.WriteLine("Введеное значение недоступно! Попробуйте еще раз");
                        Console.WriteLine("Выберите сущность[1/2]:");
                    }
                } while (menu <= 0 || menu >= 3);

                // Выбор действий
                switch (menu)
                {
                    case 1:
                        ((IHorse)action).Move();
                        break;
                    case 2:
                        ((IHuman)action).Move();
                        break;
                }

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
                        exit = 'q';
                        continue;
                    }
                    // Запрет ввода не латинских y и n
                    if (exit != 'n' && exit != 'y')
                    {
                        Console.WriteLine("Неправильно введено значение! Попробуйте еще раз");
                    }
                } while (exit != 'n' && exit != 'y');
            } while (exit == 'n'); // Выход из программы при значении 'y'
        }
    }
}
