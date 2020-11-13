using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3_Fainshtein
{
    public abstract class CGraphicsObject
    {
        protected double radius1;
        protected double radius2;
        protected double angleDeg;
        protected double width;
        protected double length;
        protected double x;
        protected double y;
        protected double arcLength;

        public abstract string Show();
    }
}