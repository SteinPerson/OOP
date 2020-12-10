using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Fainshtein
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
        protected double side1; // Первая сторона
        protected double side2; // Вторая сторона
        protected double side3; // Третья сторона
        public virtual void Show() { }
    }
}
