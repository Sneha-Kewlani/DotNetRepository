using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace memManagement
{
    public class customException : Exception
    {
        public customException(string message) : base(message)
        {

        }
    }

    public class Temperature
    {
        int temperature = 0;
        string smsg = "Zero Temperature Found!";
        public void showTemp()
        {
            try
            {
                if (temperature == 0)
                    throw (new customException("Zero Temperature Found!"));
                else
                    Console.WriteLine("Temperature is: {0}", temperature);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
