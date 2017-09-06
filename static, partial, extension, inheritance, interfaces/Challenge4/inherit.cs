using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class inherit
    {
        public string name;
        public string color;
        public int price;

        public inherit(string Name, string Color, int Price)
        {
            name = Name;
            color = Color;
            price = Price;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}, Color: {1}, Price: {2}", name, color, price);
        }

    }

    class car : inherit
    {
        string carType;
        public car(string Name, string Color, int Price, string CarType):base(Name, Color,Price)
        {
            name = Name;
            color = Color;
            price = Price;
            carType = CarType;
        }
        public void cdisplay()
        {
            Console.WriteLine("Name: {0}\n Color: {1}\n Price: {2}\n CarType: {3}", name, color, price, carType);

        }

    }

    class bike : inherit
    {
        string bikeType;
       public bike(string Name, string Color, int Price, string BikeType):base(Name, Color,Price)
        {
            name = Name;
            color = Color;
            price = Price;
            bikeType = BikeType;
        }
        public void bdisplay()
        {
            Console.WriteLine("\n\nName: {0}\n Color: {1}\n Price: {2}\n BikeType: {3}", name, color, price, bikeType);
        }
    }
}
