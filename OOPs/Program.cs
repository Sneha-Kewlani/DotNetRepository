using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inhertance
            bird1 b1 = new bird1();
            bird2 b2 = new bird2();
            Console.WriteLine("Bird 1");
            b1.walk();
            b1.fly();
            Console.WriteLine("\nBird 2");
            b2.walk();
            b2.sing();

            //Function Overloading
            Console.WriteLine("----------------------------------------------");
            clsOverloading ov = new clsOverloading();
            ov.add(13, 9);
            ov.add(13,9,2,3);
            ov.add(13, 4, 9);
            
            //Overriding
            Console.WriteLine("----------------------------------------------");
            notification n = new notification();
            n.display();
            n = new email();
            n.display();
            n = new sms();
            n.display();

            //employee
            Console.WriteLine("----------------------------------------------");
            employee em = new employee(2000);
            em = new admin(2000);
            em.salCalculate();
            em = new trainer(2000);
            em.salCalculate();
            Console.ReadLine();
        }
    }
}
