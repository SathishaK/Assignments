using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigns
{
    class Con
    {
        private int width = 0;
        private int height = 0;

        public Con(int width, int height)
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }
        public void ShowData() => Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
    }
    class Tables
    {
        static void Main(string[] args)
        {
            Con[] arr = new Con[10];
            Random value = new Random();
            for (int i = 0; i < 10; i++)
                arr[i] = new Con(value.Next(50, 200), value.Next(50, 200));
            foreach (var i in arr)
                i.ShowData();
        }
    }
}
