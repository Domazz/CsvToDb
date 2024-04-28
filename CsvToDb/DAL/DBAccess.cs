using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvToDb
{
    public class DBAccess
    {

        private static SqlConnection objConnection;
        private static SqlDataAdapter objDataAdapter;
        public static string ConnectionString = @"Data Source=LAPTOP-IUDN9I3L\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
        private static void OpenConnection()
        {
            try
            {
                if (objConnection == null)
                {
                    objConnection = new SqlConnection(ConnectionString);
                    objConnection.Open();
                }
                else
                {
                    if (objConnection.State != ConnectionState.Open)
                    {
                        objConnection = new SqlConnection(ConnectionString);
                        objConnection.Open();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }
        private static void CloseConnection()
        {
            try
            {
                if (!(objConnection == null))
                {
                    if (objConnection.State == System.Data.ConnectionState.Open)
                    {
                        objConnection.Close();
                        objConnection.Dispose();
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("" + ex);  }
        }
       public static DataTable FillDataTable(string Query, DataTable Table)
       {

            OpenConnection();
            try
            {
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
               objDataAdapter.Fill(Table);
                objDataAdapter.Dispose();
               CloseConnection();

               return Table;
            }
            catch(Exception ex)
            {
                return null;
           }
        }

        //public static SqlDataReader ExecuteReader(string cmd)
        //{
            //try
            //{
              //  SqlDataReader objReader;
               // objConnection = new SqlConnection(ConnectionString);
               // OpenConnection();
               // SqlCommand cmdRedr = new SqlCommand(cmd, objConnection);
               // objReader = cmdRedr.ExecuteReader(CommandBehavior.CloseConnection);
               // cmdRedr.Dispose();
               // return objReader;
            //}
           // catch
         //   {
              //  return null;
            //}
        //}
        public static bool ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using ( SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;//MessageBox.Show("Exception" + ex);
            }
        }
    }
}
