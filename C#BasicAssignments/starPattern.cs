using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class starPattern
    {
        public void star()
        {
            int row;
            Console.WriteLine("Enter the number of rows: ");
            row = Convert.ToInt16(Console.ReadLine());

            int i, j;
            int cnt = row;
            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= row; j++)
                {
                    if (cnt>j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                }
                Console.Write("\n");
                cnt--;
            }

            Console.ReadLine();
        }
    }
}
