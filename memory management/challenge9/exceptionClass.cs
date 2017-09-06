using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memManagement
{
    class exceptionClass
    {
        
        public void addition()
        {
            int result = 0;
            try
            {
                Console.WriteLine("Enter 2 integers: ");
                int num1 = Convert.ToInt16(Console.ReadLine());
                int num2 = Convert.ToInt16(Console.ReadLine());
               
                result = num1 + num2;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Exception {0} caught!!", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}",result);
            }
        }


      
    }
}
