using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    /*interface IEmployee
    {
        void calculateSalary();
        void AddDetails();
    }

    class partTimeEmployee : IEmployee
    {
        public void AddDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Part Time Details");
        }

        public void calculateSalary()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Part Time Employee Salary: 10000");
        }
    }
    class fullTimeEmployee : IEmployee
    {
        public void AddDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Full Time Employee Details");
        }

        public void calculateSalary()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Full Time Employee Salary: 20000");
        }
    }

    class DontKnow
    {
        public  void dontKnow(IEmployee obj)
        {
            obj.calculateSalary();
            obj.AddDetails();
        }
    }*/

    interface IVehicle
    {
        void display();
    }

    class cari : IVehicle
    {
        string name, color,carType;
        int price;
        public cari(string Name, string Color, int Price, string CarType)
        {
            name = Name;
            color = Color;
            price = Price;
            carType = CarType;
        }
        public void display()
        {
            Console.WriteLine("Name: {0}\n Color: {1}\n Price: {2}\n CarType: {3}", name, color, price, carType);

        }
    }

    class bikei : IVehicle
    {
        string name, color, bikeType;
        int price;
        public bikei(string Name, string Color, int Price, string BikeType)
        {
            name = Name;
            color = Color;
            price = Price;
            bikeType = BikeType;
        }
        public void display()
        {
            Console.WriteLine("\n\nName: {0}\n Color: {1}\n Price: {2}\n BikeType: {3}", name, color, price, bikeType);
        }
    }

}
