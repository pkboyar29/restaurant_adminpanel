using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace kursach
{
    internal class DataBase
    {
        SqlConnection con;

        private static string user;
        private static string password;

        public static string User
        {
            get { return user; }
            set { user = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DataBase()
        {
            con = new SqlConnection($"Data Source=DESKTOP-0JR6MQL\\SQLEXPRESS;Initial Catalog=RestaurantDB;User Id={User};Password={Password};");
        }

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
