using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    class exception
    {
        public void excep()
        {
            int a, b;
            a = 300000;
            b = 200000;

            try
            {
                int c = checked(a * b);
                Console.WriteLine(c);
                Console.ReadLine();
            }
            catch (SystemException e)
            {
                Console.WriteLine("Exception\n" + e);
                Console.ReadLine();
            }
        }
    }
}
