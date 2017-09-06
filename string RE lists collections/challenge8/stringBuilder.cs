using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge8
{
    class stringBuilder
    {
        private static int INITIAL_SIZE = 3;

        String[] stringList = new String[INITIAL_SIZE];

        
        int size = 0;

        
        int characterCount = 0;


        public void add(String s)
        {
            if (size < stringList.Length)
            {
                stringList[size++] = s;
                characterCount += s.Length;
            }
            else
            {
                String[] temp = new String[stringList.Length * 2];

                for (int i = 0; i < stringList.Length; i++)
                {
                    temp[i] = stringList[i];
                }

                stringList = temp;
                add(s);
            }
        }


        public String toString()
        {
            char[] output = new char[characterCount];
            int outputIndex = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < stringList[i].Length; j++)
                {
                    output[outputIndex++] = stringList[i].ElementAt(j);
                }
            }
            Console.WriteLine("\n" + output);
            return new String(output);

        }

    }
}
