using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchSampleV70
{
    public abstract class Shape
    {
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
    }
}
