using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Fainshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            EllipticalSector ellipticalSector = new EllipticalSector(12, 15, 124, 45);
            ellipticalSector.X = 12;
            ellipticalSector.Y = 34;

            t = ellipticalSector.Show();
            Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
