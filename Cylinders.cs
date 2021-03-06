using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigns
{
    public class Circle
    {
        public double radius;


        public Circle(double r)
        {
            radius = r;
        }
        public double getArea()
        {
            return Math.PI;
        }
    }
    public class Cylinders
    {
        public Circle dt;
        public double height;
        public string color;

        public Cylinders(double r, double h, string c)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinders(double r, double h)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinders(double r)
        {
            dt = new Circle(r);

        }
        public double getVolume()
        {
            return dt.getArea() * height;
        }
    }
    class start
    {
        static void Main(string[] args)
        {
            Cylinders cylinders = new Cylinders(12.34, 10.0, "blue");

            Cylinders[] circles = { new Cylinders(80), new Cylinders(12.3, 30.7), new Cylinders(12.34, 10.0, "blue") };

            Console.WriteLine(circles[1].getVolume());
        }
    }
}
