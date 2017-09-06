using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThreading
{
    class divide
    {
        static int  num1 = 0, num2 = 0, result = 0;
        public void threadExecute()
        {
            Thread t1 = new Thread(division);
            division();
            t1.Start();
      
            Console.ReadLine();
        }
        public void division()
        {
            Random r1 = new Random();
            for (int i = 0; i < 109000; i++)
                {
                    Monitor.Enter(this);
                       num1 = r1.Next(1, 20);
                       num2 = r1.Next(1, 2);
                       result = num1 / num2;

                        Console.WriteLine("Division of {0} and {1} is {2}", num1, num2, result);

                        num1 = 0;
                        num2 = 0;
            
                   Monitor.Exit(this);
                }
 
           
            
        }
    }
}
