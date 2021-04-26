using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace CourseWork
{
    public static class DatabaseManager
    {
        public static SqlConnection Get_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.connection_string;
            SqlConnection cn_connection = new SqlConnection(cn_String);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
            return cn_connection;
        }

        public static DataTable Get_DataTable(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, cn_connection);
            adapter.Fill(table);
            return table;
        }

        public static void Execute_SQL(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();
            SqlCommand cmd_Command = new SqlCommand(SQL_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }

        public static void Close_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.connection_string;
            SqlConnection cn_connection = new SqlConnection(cn_String);
            if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
        }

        public static bool IsCorrectLogin(string username, string password)
        {
            var con = Properties.Settings.Default.connection_string;
            User matchingPerson = new User();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where Username=@username";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@username", username);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        matchingPerson.Username = oReader["Username"].ToString();
                        matchingPerson.Password = oReader["Password"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return matchingPerson.Username == username && matchingPerson.Password == password;
        }



        public static void CreateUser(string username, string password, string name, string surname)
        {
            string sql_Add = "INSERT INTO Users ([Username],[Password],[Name],[Surname]) VALUES('" + username + "','" + password + "','" + name + "','" + surname + "')";
            Execute_SQL(sql_Add);
        }
    }
}