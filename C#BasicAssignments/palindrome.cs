using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class palindrome
    {
        public void palin()
        {
            Console.WriteLine("Enter the string: ");
            string s = Convert.ToString(Console.ReadLine());
            string rev = "";

            int n = s.Length;
            for (int i = n - 1; i >= 0; i--) 
            {
                rev += s[i].ToString();
            }

            if (rev == s)
                Console.WriteLine("String is palindrome! \nReverese string is: {0}", rev);
            else
                Console.WriteLine("String is not a palindrome! \nReverse String is: {0}", rev);


            Console.ReadLine();
        }
       
    }
}
