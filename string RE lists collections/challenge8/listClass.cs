using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge8
{
    class listClass<T>
    {
        public void testMethod(T a)
        {
            List<T> l = new List<T>();
            l.Add(a);

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

        }
    }
}
