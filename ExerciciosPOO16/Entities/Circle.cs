using System;
using System.Collections.Generic;
using ExerciciosPOO16.Entities.Enum;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO16.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius, Color color)
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
