using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThreading
{
    class multiThread
    {
        public void threadExecute()
        {
            Thread t1 = new Thread(function1);
            Thread t2 = new Thread(function2);
            t1.Start();
            t2.Start();
            Console.ReadLine();            
        }

        static void function1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 1");
                // Console.ReadLine();
            }
        }

        static void function2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Thread 2");
                // Console.ReadLine();
            }
        }
    }
}
