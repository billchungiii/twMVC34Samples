using System;
using System.Collections.Generic;

namespace SwitchSampleV70
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var shape in GetShapes())
            {
                Console.WriteLine(GetArea(shape));
            }
        }

        static double GetArea(Shape shape)
        {          
            switch (shape)
            {
                case Rectangle r:
                    return r.Width * r.Height;
                case Circle c:
                    return Math.Pow(c.Radius, 2) * Math.PI;
                default:
                    throw new ArgumentException();
            }
        }

        static List<Shape> GetShapes()
        {
            return new List<Shape>
            {
                new Rectangle { Width = 5, Height =5 },
                new Rectangle { Width = 15, Height =5 },
                new Circle { Radius = 6 },
                new Rectangle { Width = 5, Height =5 },
                new Circle { Radius = 10 },

            };
        }
    }
}
