using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThreading
{
    class threadPool
    {
        public void threadExecute()
        {
            ThreadPool.QueueUserWorkItem(function1, 10);
            Console.ReadLine();
        }
       

    static void function1(Object stateInfo)
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
