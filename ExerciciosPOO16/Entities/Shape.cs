using System;
using System.Collections.Generic;
using System.Linq;
using ExerciciosPOO16.Entities.Enum;

using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO16.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape() { }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
