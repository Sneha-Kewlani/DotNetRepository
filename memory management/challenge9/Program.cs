using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace memManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            disposableGC d = new disposableGC();
            //d.func();
            exceptionClass ec = new exceptionClass();
            //ec.division(10, 0);
            //ec.division(400, 20);
            //ec.addition();
            Temperature t = new Temperature();
            t.showTemp();
           
           

            Console.ReadLine();


        }
    }
}
