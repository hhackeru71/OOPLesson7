using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson7.Task
{
    internal class Line : Shape
    {
        public double X { get; set; }

        public Line(double x)
        {
            X = x;
        }

        public override double GetArea()
        {
            return X;
        }
    }
}
