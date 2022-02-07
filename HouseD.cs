using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class HouseD
   
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Sathish");
            apartment.door = new House.Door("White");
            person.house = apartment;
            person.ShowData();
        }
    }

    public class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am in house, my area is {Area} ");
        }

        public Door GetDoor()
        {
            return door;
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color = "brown")
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"  door color is {Color}");
            }
        }
    }

    public class SmallApartment : House
    {
        public SmallApartment(int area = 50) : base(area)
        {
        }
    }

    public class Person
    {
        private string name;
        public House house { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"A person whose name is {name}");
            Console.WriteLine("Data of house:");
            house.ShowData();
            Console.WriteLine("Data of door:");
            house.GetDoor().ShowData();
        }
    }
}

