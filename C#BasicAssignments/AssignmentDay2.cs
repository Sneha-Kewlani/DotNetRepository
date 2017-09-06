using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class AssignmentDay2
    {
        //------------------------------------------------------------------------------------------------------------------

        public void numPrint()
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt16(Console.ReadLine());

            for(int i=0; i<2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}",n,n,n,n);
                Console.WriteLine("{0}{0}{0}{0}", n, n, n, n);
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        public void rectangle()
        {
            Console.WriteLine("Enter a number: ");
            int r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", r,r, r);
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("{0} {0}", r, r);
            }
            Console.WriteLine("{0}{0}{0}", r, r, r);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void celsiusToFah()
        {
            Console.WriteLine("Enter the temperature in celsius: ");
            int celsius = Convert.ToInt16(Console.ReadLine());

            int faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("The Temperature in fahrenheit is: {0}", faren);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void longestWord()
        {
            Console.WriteLine("Enter the string ");
            string line = Convert.ToString(Console.ReadLine());

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int len = 0;
            foreach (String s in words)
            {
                if (s.Length > len)
                {
                    word = s;
                    len = s.Length;
                }
            }

            Console.WriteLine("The longest word is: {0}",word);
        }

        //------------------------------------------------------------------------------------------------------------------

        public bool IsPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public void sumPrime()
        {
            
            long sum = 0;
            int cnt = 0;
            int n = 2;
           

            while(cnt<500)
            {
                if (IsPrime(n))
                { 
                    sum = sum + n;
                    cnt++;
                }
                n++;
            }
            Console.WriteLine("Sum of first 500 prime numbers is: {0}", sum);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void reverseSentence()
        {
            Console.WriteLine("Enter the string ");
            string sentence = Convert.ToString(Console.ReadLine());
            Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));
        }

        //------------------------------------------------------------------------------------------------------------------

        public void leapYear()
        {
            Console.WriteLine("Enter the year ");
            int year = Convert.ToInt16(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void largeNumber()
        {
            Console.WriteLine("Enter three numbers: ");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());

            if(a>b && a>c)
                Console.WriteLine("{0} is the largest of three.", a);
            else if(b>a && b>c)
                Console.WriteLine("{0} is the largest of three.", b);
            else
                Console.WriteLine("{0} is the largest of three.", c);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void temperature()
        {
            Console.WriteLine("Enter the temperature in celsius: ");
            int temperature = Convert.ToInt16(Console.ReadLine());

            if(temperature<0)
                Console.WriteLine("Frezzing Weather at {0}", temperature);
            else if(temperature>=0 && temperature<=10)
                Console.WriteLine("Very Cold Weather at {0}", temperature);
            else if (temperature >= 10 && temperature <= 20)
                Console.WriteLine("Cold Weather at {0}", temperature);
            else if (temperature >= 20 && temperature <= 30)
                Console.WriteLine("Normal Weather at {0}", temperature);
            else if (temperature >= 30 && temperature <= 40)
                Console.WriteLine("Hot Weather at {0}", temperature);
            else
                Console.WriteLine("Very Hot Weather at {0}", temperature);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void alphabet()
        {
            Console.WriteLine("Enter any Alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if(alphabet=='a' || alphabet=='e' || alphabet=='i' || alphabet=='o' ||alphabet=='u')
                Console.WriteLine("{0} is a vowel",alphabet);
            else
                Console.WriteLine("{0} is a consonant", alphabet);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void electricityBill()
        {
            Console.WriteLine("Enter Customer ID: ");
            int custId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Units consumed: ");
            int units = Convert.ToInt16(Console.ReadLine());

            double amt=0.0, surcharge=0.0, total=0.0;

            if(units>=0 && units<=199)
            {
                amt = units * 1.20;
            }
            else if (units >= 200 && units <= 400)
            {
                amt = units * 1.50;
            }
            else if (units >= 400 && units <= 600)
            {
                amt = units * 1.80;
            }
            else if (units >= 600)
            {
                amt = units * 2.0;
            }

            if(amt>400)
            {
                surcharge = 0.15 * amt;
                total = surcharge + amt;
            }
            else
            {
                total = amt;
            }

            if (amt < 100)
            {
                Console.WriteLine("Bill should be minimum 100Rs");
            }
            else
            {
                Console.WriteLine("Customer Id: {0} \n Name: {1} \n Units: {2} \n Amount: {3} \n Surcharge Amount: {4} \n Total: {5}", custId, name, units, amt, surcharge, total);
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        public void calculator()
        {
            Console.WriteLine("Enter First Number ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            
            while (true)
            {
                Console.WriteLine("****MENU****\n1)Addition\n2)Subtraction\n3)Multiplication\n4)Division\n5)Exit");
                int choice;

                Console.WriteLine("Enter your choice ");
                choice = Convert.ToInt16(Console.ReadLine());
                int result;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}",num1,num2,result);
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                        break;
                    case 4:
                        result = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                        break;
                    case 5:
                        return;
                        
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        public void cube()
        {
            Console.WriteLine("Enter number of terms ");
            int range = Convert.ToInt16(Console.ReadLine());

            for(int i=1; i<=range; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is: {0} and Cube of {0} = {1}", i,cube);
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        public void convertBinary()
        {
            Console.WriteLine("Enter the number to be converted: ");
            int numb = Convert.ToInt16(Console.ReadLine());
            int toBase = 2;
            string binary = Convert.ToString(numb, toBase);
            Console.WriteLine("Binary of {0} = {1}", numb, binary);
        }

        //------------------------------------------------------------------------------------------------------------------

        public void patternWidth()
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        public void patternDiamond()
        {
            int i, j, r;
            

            Console.Write("Input number of rows :");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }


        //------------------------------------------------------------------------------------------------------------------

            public void patternNum()
            {
                int i, j, n;

                              Console.Write("Input number of rows : ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i <= n; i++)
                {
                    
                    for (j = 1; j <= n - i; j++)
                        Console.Write(" ");
                    
                    for (j = 1; j <= i; j++)
                        Console.Write("{0}", j);

                    for (j = i - 1; j >= 1; j--)
                        Console.Write("{0}", j);

                    Console.Write("\n");
                }
            }
            
        
    }
}

              
           