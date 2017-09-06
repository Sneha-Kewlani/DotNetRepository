using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace adoDotNet1
{
    public class sqlHelper
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public string sqlQuery = null;
        private string conString = @"Data Source=SNEHA-KL;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False";

        public sqlHelper()
        {
            sqlConnection = new SqlConnection(conString);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
                Console.WriteLine("Connection is Open");
            }
        }

        public string ExecuteScalar(string sqlQuery1)
        {
            sqlCommand = new SqlCommand(sqlQuery1, sqlConnection);
            return sqlCommand.ExecuteScalar().ToString();
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand.ExecuteReader();
        }

        public bool ExecuteNonQuery(string sqlSaveData)
        {
            bool result = false;
            sqlCommand = new SqlCommand(sqlSaveData, sqlConnection);
            var count = sqlCommand.ExecuteNonQuery();
            if(count > 0)
            {
                result = true;
            }
            return result;
        }


        public DataTable getDataSet(string query)
        {
            var ds = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, conString);
            sqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];

        }

        public void update(int nroll, string nname, int nmarks, string ncontact, int uroll)
        {

           string Query = string.Format(@"update[Table] set RollNo = {0}, StudentName = '{1}', Marks = {2}, ContactNumber = '{3}' where RollNo = {4}", nroll, nname, nmarks, ncontact, uroll);
            SqlConnection MyConn2 = new SqlConnection(conString);
            SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
            SqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            Console.WriteLine("Data Updated");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
           

        }

        public void delete( int uroll)
        {

            string Query = string.Format(@"delete from [Table] where RollNo = {0}", uroll);
            SqlConnection MyConn2 = new SqlConnection(conString);
            SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
            SqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            Console.WriteLine("Data Deleted");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();


        }
    }
}
