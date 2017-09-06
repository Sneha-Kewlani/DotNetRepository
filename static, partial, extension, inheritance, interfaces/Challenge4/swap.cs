using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class swap
    {
        public void swapNums()
        {
            Console.WriteLine("Enter the two numbers: ");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Before Swapping\na = {0}\nb = {1}", a,b);

            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping\na = {0}\nb = {1}", a, b);
        }

    }
    class operations
    {
        public void table()
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            int t;
            for(int i=1; i<=10; i++)
            {
                t = a * i;
                Console.WriteLine("{0} * {1} = {2}", a,i,t);
            }
        }

        public void removeVowels()
        {
            Console.WriteLine("Enter a word: ");
            string str = Convert.ToString(Console.ReadLine());

            int length = str.Length;
            
            for(int i=0; i<=length-1; i++)
            {
                if(str[i]=='a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                        str = str.Replace(str[i], ' ');
  
                }
            }
            Console.WriteLine("String without vowels: ");
            for (int i = 0; i <= length-1; i++)
            {
                if (str[i]!=' ')
                {
                        Console.Write(str[i]);           
                }
            }


        }
    }
}
