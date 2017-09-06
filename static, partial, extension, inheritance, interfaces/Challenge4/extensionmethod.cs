using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Challenge4
{
    public static class extensionmethod
    {
        /*public static int factorial(this int x)
        {
            if (x <= 1) return 1;
            if (x == 2) return 2;
            else
               return x* factorial(x - 1);

        }*/
        public static string toupperCase(this string s)
        {
            //string str = s.ToUpper();

            string str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
            return str;
            
        }
    }
}
