using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adoDotNet1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                student s = new student();
                s.deleteDataSet();
                //s.updateDataSet();
                //getDataSet();
                //s.saveData();
                //s.GetData();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
