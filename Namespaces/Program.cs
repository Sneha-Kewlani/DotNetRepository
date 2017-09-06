using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalVar;
using n = nested.nestedIn;

namespace Challenge3
{
    class Program
    {
        static int Main(string[] args)
        {
            /*global::System.Console.WriteLine();
            GlobalVar.Console gg = new GlobalVar.Console() ;
            gg.WriteLine();

            n.nest nn = new n.nest();
            nn.print();*/
            
            global::System.Console.ReadLine();
            
            return 0;
        }
    }
}

namespace GlobalVar
{
    public class Console
    {
        public void WriteLine()
        {
            global::System.Console.WriteLine("Sneha");
        }
    }
}

namespace nested
{
    namespace nestedIn
    {
        class nest
        {
            public void print()
            {
                global::System.Console.WriteLine("Sneha in nested");
            }
        }
    }
}