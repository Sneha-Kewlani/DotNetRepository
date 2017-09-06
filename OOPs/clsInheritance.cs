using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    public class birds
    {
        public void walk()
        {
            Console.WriteLine("Birds walk");
        }
    }

    public class bird1 : birds
    {
        public void fly()
        {
            Console.WriteLine("Bird1 fly");
        }
    }

    public class bird2 : birds
    {
        public void sing()
        {
            Console.WriteLine("Bird2 sing");
        }
    }
}
