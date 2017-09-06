using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace adoDotNet1
{
    public class student
    {
        public sqlHelper sqlhelper;
        public string sqlQuery, sqlQuery1, sqlSaveData;

        public student()
        {
            sqlhelper = new sqlHelper();
        }

        public void GetData()
        {
            sqlQuery = "select * from [Table]";
          

           var sqlReader = sqlhelper.ExecuteQuery(sqlQuery);

            if(sqlReader.HasRows)
            {
                while(sqlReader.Read())
                {
                    Console.WriteLine(string.Format("Roll Number: {0}\tStudent Name: {1}",sqlReader[0], sqlReader[1]));
                }
               
            }
            sqlReader.Close();

            sqlQuery1 = "select COUNT(*) from [Table]";
            var count = sqlhelper.ExecuteScalar(sqlQuery1);
            Console.WriteLine(string.Format("No. of Rows: {0}",count));

        }


        public void saveData()
        {
            Console.WriteLine("Enter the details: ");
            string rno = Console.ReadLine();
            string name = Console.ReadLine();
            string marks = Console.ReadLine();
            string contact = Console.ReadLine();
            sqlSaveData = string.Format(@"insert into[Table] values({0}, '{1}', {2}, '{3}')", rno, name, marks, contact);

            bool status = false;
            status = sqlhelper.ExecuteNonQuery(sqlSaveData);
            if(status)
            {
                GetData();
            }
            else
            {
                Console.WriteLine("Record not inserted");
            }

        }
      

        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt = sqlhelper.getDataSet(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll Number: {0}\tStudent Name: {1}", dr[0].ToString(), dr[1].ToString()));
            }

            dt.WriteXml("student.xls");
        }

        public void updateDataSet()
        {
            Console.WriteLine("Enter the roll no. of the entry to be updated: ");
            int uroll = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the updated roll no: ");
            int nroll = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the updated name: ");
            string nname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the updated marks: ");
            int nmarks = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the updated contact: ");
            string ncontact = Convert.ToString(Console.ReadLine());

            
            sqlhelper.update(nroll, nname, nmarks, ncontact, uroll);
            GetData();
            /*reach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll Number: {0}\tStudent Name: {1}", dr[0].ToString(), dr[1].ToString()));
            }
            */
        }


        public void deleteDataSet()
        {
            GetData();
            Console.WriteLine("Enter the roll no. of the entry to be deleted: ");
            int uroll = Convert.ToInt16(Console.ReadLine());

           
            sqlhelper.delete(uroll);
            GetData();
            /*reach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("Roll Number: {0}\tStudent Name: {1}", dr[0].ToString(), dr[1].ToString()));
            }
            */
        }

    }
}
