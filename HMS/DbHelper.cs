using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class DbHelper
    {
        private static readonly string connectionString =
            (@"Data Source=.\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");

        // OPEN CONNECTION
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // SELECT (returns DataTable)
        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // INSERT / UPDATE / DELETE
        public static int ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
