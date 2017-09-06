using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThreading
{
    class foregroundBackground
    {
        public void fb()
        {
            Thread t1 = new Thread(function1);
            Thread t2 = new Thread(function2);
            t2.IsBackground = true;
            
            t1.Start();
            t2.Start();
            Console.WriteLine("main thread end");
            Console.ReadLine();
        }

        static void function1()
        {
                Console.WriteLine("Foreground thread ");
                 Console.ReadLine();
                Console.WriteLine("Foreground thread end ");

        }

        static void function2()
        {
                Console.WriteLine("Background thread");
                 Console.ReadLine();
                Console.WriteLine("Background thread end ");

        }
    }
}
