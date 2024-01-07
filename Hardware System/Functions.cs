using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hardware_System
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter Sda;

        public int SetData(String Query)
        {
            int Cnt;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }
        public Functions()
        {
            ConStr = @"Data Source=DESKTOP-OR2N5UH\SQLEXPRESS;Initial Catalog=HardwareDB;Integrated Security=True";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }


    }
}
