using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generic Classes
            generic<int> intGeneric = new generic<int>();
            int a = 9;
            int b = 13;
            intGeneric.swap(ref a, ref b);

            //generic<string> strGeneric = new generic<string>();
            //strGeneric.swap("Sneha", "Jill");



            Console.ReadLine();
        }
    }
}
