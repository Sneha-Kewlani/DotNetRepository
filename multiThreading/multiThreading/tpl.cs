using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThreading
{
    class tpl
    {

        public void threadExecute()
        {
            Parallel.For(0, 10, x=>function1());
            Console.ReadLine();
        }

       
        static void function1()
        {
            string x = "";
            for (int i = 0; i < 10; i++)
            {
                x = x + "s";
                Console.WriteLine(x);
                // Console.ReadLine();
            }
        }
    }
}
