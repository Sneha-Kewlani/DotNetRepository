using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    class delegateClass
    {
        public delegate void CalculateSimpleInterest(int p, int r, int t);

        public delegate void BankName(string bank);

        public event BankName SIEvent;

        public void RaiseEvent(string message)
        {
            if (SIEvent != null)
                SIEvent(message);
        }

        public void getTotalInterest(int principle, int rate, int time)
        {
            int simpleInterest = principle * rate * time;
            Console.WriteLine("Simple interest = {0}", simpleInterest);
        }

        public void getInterestRatePerYear(int principle, int rate, int time)
        {
            Console.WriteLine("The interest rate per year is: {0}", rate);
        }

        public void anony()
        {
            CalculateSimpleInterest d1 = delegate (int principle, int rate, int time)
            {
                int simpleInterest = principle * rate * time;
                Console.WriteLine("Anonymous Simple interest = {0}", simpleInterest);

            };
            d1(10, 10, 2);
        }

        public void getBankName(string bname)
        {
            Console.WriteLine("\nBank Name is {0}", bname);
        }

    }
}
    
         