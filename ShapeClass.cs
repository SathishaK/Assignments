using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Shape
    {
        public bool Fillcolor { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            string oldValue = "Shape ";
            string value = "";
            if (Fillcolor == true) value = "filled"; else value = "Not Filled";
            oldValue += $"| A Shape  with color {Color} and {value}";
            return oldValue;
        }
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Rectange|A Rectange with width = {Width} and Length = {Length} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
    class Circle : Shape
    {
        public int Radius { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Circle|A Circle with radius={Radius} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
    class Square : Shape
    {
        public int Side { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Square|A Square with radius={Side} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
    internal class ShapeClass
    {
        static void Main(string[] args)
        {
            Shape xxx = new Shape { Color = "Yellow", Fillcolor = true };
            Console.WriteLine(xxx);

            xxx = new Rectangle { Length = 200, Width = 300 };
            Console.WriteLine(xxx);

            xxx = new Circle { Radius = 10 };
            Console.WriteLine(xxx);

            xxx = new Square { Side = 4 };
            Console.WriteLine(xxx);
        }
    }
}