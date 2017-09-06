using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    class boxUnbox
    {
        public void box()
        {
            int i = 20;
            object o = i;
            Console.WriteLine("Boxed value: " + o);
            int j = (int)o;
            Console.WriteLine("Unboxed value: " + j);
            Console.ReadLine();
        }
    }
}
