using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_Fainshtein
{
    public class CPoint : CGraphicsObject
    {
        public CPoint()
        {
            x = 0;
            y = 0;
        }

        ~CPoint()
        {
            Console.WriteLine("Координаты удалены");
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string Show()
        {
            return "Координаты точки: X = " + X + "Y = " + Y;
        }
    }
}