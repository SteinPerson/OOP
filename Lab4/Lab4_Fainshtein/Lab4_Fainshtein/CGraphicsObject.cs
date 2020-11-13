using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4_Fainshtein
{
    public abstract class CGraphicsObject
    {
        protected double radius1; // Первый Радиус
        protected double radius2; // Второй Радиус
        protected double angleDeg; // Угол
        protected double width; // Ширина
        protected double length; // Длина
        protected List<Point> points; // Координаты
        protected double arcLength; // Длина дуги

        public abstract double Area(); // Площадь
        public virtual void Show(Label label) { }
        public virtual void Draw(PaintEventArgs e) { }
        public virtual string GetClassName() 
        {
            return "CGraphicsObject";
        }

        public static bool operator >=(CGraphicsObject tr1, CGraphicsObject r1)
        {
            return tr1.Area() >= r1.Area();
        }
        public static bool operator <=(CGraphicsObject tr1, CGraphicsObject r1)
        {
            return tr1.Area() <= r1.Area();
        }
    }
}
