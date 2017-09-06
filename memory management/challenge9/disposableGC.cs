using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace memManagement
{
    class disposableGC : IDisposable
    {
        public void func()
        {
            string path = @"C:\Users\kewlani_s\Desktop\edit.txt";
            FileStream fs = File.Create(path);
            StreamWriter sw = null;

            StreamReader sr = null;
            try
            {
                sw = new StreamWriter(fs);
                sw.WriteLine("using disposable");
            }
            finally
            {
                sw.Dispose();
            }

            try
            {
                sr = File.OpenText(path);
           
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
            }
            finally
            {
                sr.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)

        {
            if(disposing)
            {
                GC.SuppressFinalize(this);
            }
            
        }
    }
}
