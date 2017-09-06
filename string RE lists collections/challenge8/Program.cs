using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*listClass<string> l = new listClass<string>();
            
            l.testMethod("Kewlani");
            l.testMethod("Sneha");
            l.testMethod("Komal");
            l.testMethod("Neha");
            l.testMethod("Kittu");
            l.testMethod("Pooja");*/

            stringBuilder sb = new stringBuilder();

            
            int i = 0;

            while (i != 3)
            {

                printMenu();
                i = Convert.ToInt16( Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Enter string");
                    sb.add(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.WriteLine("\n"+sb.toString());
                }
                
                Console.ReadLine();

            }


        }

        private static void printMenu()
        {
            Console.WriteLine("StringBuilder Options :");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.ToString and Display");
            Console.WriteLine("3.Quit");
        }

       
        }
}

