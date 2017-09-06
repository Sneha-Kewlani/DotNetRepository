using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace memManagement
{
    public class usingFileGC
    {
        public void usingGC()
        {
            string path = @"C:\Users\kewlani_s\Desktop\edit.txt";
            FileStream fs = File.Create(path);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("SnehaKewlani");
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
