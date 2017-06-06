using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace SuperHero
{
    class MyUtilities
    {

        public static SqlDataReader GetMyStates()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = @GetConnectionString();
            string strSQL = "SELECT * FROM States ORDER BY State";

            conn.ConnectionString = strConn;
            comm.Connection = conn;
            comm.CommandText = strSQL;

            conn.Open();

            SqlDataReader dr = comm.ExecuteReader();
            return dr;
        }



        public static string GetConnectionString()
        {
            return "Server=sql.neit.edu,4500; Database=SE255_SVereen; User Id=SE255_SVereen; Password=001391252;";
        }
    }
}
