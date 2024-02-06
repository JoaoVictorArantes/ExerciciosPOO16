using ExerciciosPOO16.Entities;
using ExerciciosPOO16.Entities.Enum;
using Rectangle = ExerciciosPOO16.Entities.Rectangle;

namespace ExerciciosPOO16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                char ShapeAux = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ShapeAux == 'r' || ShapeAux == 'R')
                {
                    Console.Write("Width: ");
                    double Width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double Height = double.Parse(Console.ReadLine());
                    

                    list.Add(new Rectangle(Width, Height, color));
                }
                else if (ShapeAux == 'c' || ShapeAux == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color ));
                }
            }

            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}
