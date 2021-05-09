using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using CourseWork.Models;

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

        public static List<StudentModel> GetCreditHistoryOfUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection_string);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Students", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Students");
                StudentModel co = new StudentModel();
                IList<StudentModel> co1 = new List<StudentModel>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    co1.Add(new StudentModel
                    {
                        Address = dr[1].ToString(),
                        Phone = dr[2].ToString(),
                        ParrentFullName = dr[3].ToString(),
                        LivingInHostel = dr[4].ToString()

                    });
                }
                return (List<StudentModel>)co1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                return new List<StudentModel>();
            }
        }

        public static List<ModuleModel> GetModulesList()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection_string);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Modules", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Modules");
                ModuleModel co = new ModuleModel();
                IList<ModuleModel> co1 = new List<ModuleModel>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    co1.Add(new ModuleModel
                    {
                        Lesson = dr[1].ToString(),
                        Date = dr[2].ToString()
                    });
                }
                return (List<ModuleModel>)co1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                return new List<ModuleModel>();
            }
        }

        public static List<VisitModel> GetVisitsList()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.connection_string);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Visits", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Visits");
                VisitModel co = new VisitModel();
                IList<VisitModel> co1 = new List<VisitModel>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    co1.Add(new VisitModel
                    {
                        Username = dr[1].ToString(),
                        Lesson = dr[2].ToString(),
                        Date = dr[3].ToString()
                    });
                }
                return (List<VisitModel>)co1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                return new List<VisitModel>();
            }
        }

        public static void CreateUser(string username, string password, string name, string surname)
        {
            string sql_Add = "INSERT INTO Users ([Username],[Password],[Name],[Surname]) VALUES('" + username + "','" + password + "','" + name + "','" + surname + "')";
            Execute_SQL(sql_Add);
        }

        public static void CreateStudent(string address, string phone, string parentFullName, string livingInHostel)
        {
            string sql_Add = "INSERT INTO Students ([Address],[Phone],[ParentFullName],[LivingInHostel]) VALUES('" + address + "','" + phone + "','" + parentFullName + "','" + livingInHostel + "')";
            Execute_SQL(sql_Add);
        }

        public static void CreateModule(string lesson, string date)
        {
            string sql_Add = "INSERT INTO Modules ([Lesson],[Date]) VALUES('" + lesson + "','" + date + "')";
            Execute_SQL(sql_Add);
        }

        public static void CreateVisit(string username, string lesson, string date)
        {
            string sql_Add = "INSERT INTO Visits ([Username],[Lesson],[Date]) VALUES('" + username + "','" + lesson + "','" + date + "')";
            Execute_SQL(sql_Add);
        }
    }
}