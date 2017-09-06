using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace challenge7
{
    class generic<T>
    {
        public void swap(ref T a, ref T b)
        {
            T temp;

            Console.WriteLine("Before swap:\na={0}, b={1}", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swap:\na={0}, b={1}\n\n", a, b);
        }
    }
}
