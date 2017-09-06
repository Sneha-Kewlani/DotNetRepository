using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    public class typecasting
    {
        public void typecast()
        {
            int a, b;
            a = 300000;
            b = 200000;
            Console.WriteLine(sizeof(float));
            //Console.WriteLine(typeof());

            long val = 3000000000;

            if(a is float)
            {
                Console.WriteLine("a is float");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("a is not float");
                Console.ReadLine();
            }

            
        }

        public void abc()
        {
            object[] myObj = new object[5];
            myObj[0] = new myBase();
            myObj[1] = "string";
            myObj[2] = 32;
            myObj[3] = null;
            myObj[4] = new myDerived();

            for (int i = 0; i < myObj.Length; i++)
            {

                string s = myObj[i] as string;
                Console.WriteLine("{0}: ", i);
                if (s != null)
                    Console.WriteLine("'" + s + "'");
                else
                    Console.WriteLine("not a string");
            }

        }
    }

    public class myBase
    {
        public void basef()
        {
            Console.WriteLine("Base Class");
       }
    }
    public class myDerived : myBase
    {
        public void bderivedf()
        {
            Console.WriteLine("Derived");
        }
    }
}
