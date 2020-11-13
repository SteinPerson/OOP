using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_Fainshtein
{
    public class EllipticalSector : CPoint
    {
        public EllipticalSector(double rad1, double rad2, double arcS, double angleD)
        {
            radius1 = rad1;
            radius2 = rad2;
            arcLength = arcS;
            angleDeg = angleD;
        }

        ~EllipticalSector()
        {
            Console.WriteLine("Эллептический сектор удален");
        }

        public double Radius1 // Первый радиус
        {
            get { return radius1; }
            set { radius1 = value; }
        }

        public double Radius2 // Второй радиус
        {
            get { return radius2; }
            set { radius2 = value; }
        }

        public double AngleDeg // Градус угла
        {
            get { return angleDeg; }
            set { angleDeg = value; }
        }

        public double ArcLength // Длина дуги
        {
            get { return arcLength; }
            set { arcLength = value; }
        }

        public override string Show()
        {
            return "Первый радиус сектора = " + Radius1 + ", второй радиус сектора = " + Radius2 + ", дуга = " + ArcLength
                + ", угол = " + AngleDeg + ", координаты: " + X + ", " + Y;
        }
    }
}