using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Organization_of_storage
{
    internal class Pogreb
    {
        SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-GQ3QLR4\SQLEXPRESS;
                                Initial Catalog = Погреб; Integrated Security = True");
        public void open_connect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void close_connect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connect;
        }
    }
}
