using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*delegateClass cobj = new delegateClass();
            delegateClass.CalculateSimpleInterest sidobj = new delegateClass.CalculateSimpleInterest(cobj.getTotalInterest);
            sidobj += new delegateClass.CalculateSimpleInterest(cobj.getInterestRatePerYear);
            sidobj(10, 10, 2);

            cobj.anony();

            cobj.SIEvent  += new delegateClass.BankName(cobj.getBankName);

            cobj.RaiseEvent("HDFC bank");*/

            employee e = new employee();
            e.employyeFunction();




            Console.ReadLine();

        }      
    }
}


         /* typecasting t = new typecasting();
            Console.WriteLine(typeof(string));
            Console.WriteLine(2*4+7);
            t.typecast();
            t.abc();
            exception ex = new exception();
            ex.excep();
            exception e = new exception();
            exception temp = e;

            bool b1 = ReferenceEquals(null, null);
            bool b2 = ReferenceEquals(null, ex);
            bool b3 = ReferenceEquals(ex, e);
            bool b4 = ex.Equals(e);
            bool b5 = ReferenceEquals(temp, e);
            bool b6 = e.Equals(temp);
            bool b7 = ex == e;
            bool b8 = temp == e;

            Console.WriteLine(b1+" "+b2+" "+b3+ " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " + b8);

            boxUnbox bu = new boxUnbox();
             bu.box();


            myBase d = new myDerived();
            myBase b = new myBase();

            myDerived d1 = (myDerived)d;
            d1.bderivedf();
            d1.basef();
           myDerived d2 = (myDerived)b;*/
