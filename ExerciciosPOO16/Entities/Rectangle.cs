using System;
using System.Collections.Generic;
using ExerciciosPOO16.Entities.Enum;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO16.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape Color { get; set; }


        public Rectangle(double width, double height, Color color)
            :base (color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }

    }
}
