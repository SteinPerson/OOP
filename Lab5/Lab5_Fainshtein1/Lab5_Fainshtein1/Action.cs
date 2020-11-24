using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fainshtein1
{
    class Action : IHorse, IHuman
    {
        void IHorse.Move()
        {
            Console.WriteLine("Конь поскакал!");
        }

        void IHuman.Move()
        {
            Console.WriteLine("Человек пошел!");
        }
    }
}
