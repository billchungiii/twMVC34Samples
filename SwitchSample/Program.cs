using System;
using System.Collections.Generic;
using System.Drawing;

namespace SwitchSample
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

        static double GetArea(Shape shape) => shape switch
        {
            Rectangle r => r.Width * r.Height,
            Circle c => Math.Pow(c.Radius, 2) * Math.PI,
            _ => throw new ArgumentException()
        };
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
