using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CMS.DAL;

namespace CMS
{
    class DataAccessLayer
    {

        public static SqlConnection GetConnection()
        {
            string strConnection = "Data Source = DESKTOP-GMB1CJ4\\SQLEXPRESS ; Initial Catalog = CourseManagementSystem ; Integrated Security = True ; ";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
               // MessageBox.Show("Succesfull");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Failure!");
            }
            return connection;
        }
        public static SqlDataReader GetTeacherData()
        {
            string qry = "select * from Teacher;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static SqlDataReader GetCourseData()
        {
            string qry = "select * from Courses;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static void AddCourseRecord(string courseID, string c_Name, string c_Chours)
        {
            string qry = "insert into Courses(@CourseID,@C_Name,@C_CHours)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Parameters.AddWithValue("@C_Name", c_Name);
            command.Parameters.AddWithValue("@C_CHours", c_Chours);
        }

        public static void AddTeacherRecord(string TID, string T_Name, int T_Age, string T_Contact,string H_Qual,int T_Expe)
        {
            string qry = "insert into Teacher(@TeacherID,@T_Name,@T_Age,@T_Contact,@H_Qualification,@T_Experience)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@TeacherID", TID);
            command.Parameters.AddWithValue("@T_Name", T_Name);
            command.Parameters.AddWithValue("@T_Age", T_Contact);
            command.Parameters.AddWithValue("@T_Contact", H_Qual);
            command.Parameters.AddWithValue("@H_Qualification", T_Expe);

        }
        public static DataSet GetDataThroughDataAdapter() //Disconnected Layer
        {
            string qry = "SELECT* FROM Courses;";
            SqlConnection conn = GetConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Courses");
            return ds;
        }

        // SEARCH
        public static SqlDataReader SearchCourse(string CourseID)
        {
            string qry = "select * from Courses where CourseID = " + CourseID + ";";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader SearchTeacher(string TeacherID)
        {
            string qry = "select * from Teacher where TeacherID = " + TeacherID + ";";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        // UPDATE
        public static void UpdateCourseRecord(string courseID, string c_Name, string c_Chours)
        {
            string qry = "update Courses set C_Name = @C_Name, C_Chourse = @C_Chours where CourseID = @CourseID;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Parameters.AddWithValue("@C_Name", c_Name);
            command.Parameters.AddWithValue("@C_CHours", c_Chours);
            command.ExecuteNonQuery();
        }

        public static void UpdateTeacherRecord(string teacherID, string t_Name, int t_Age, string t_Contact, string h_Qualification, float t_Experience)
        {
            string qry = "update Teacher set T_Name = @T_Name, T_Age = @T_Age, T_Contact = @T_Contact, H_Qualification = @H_Qualification, T_Experience = @T_Experience where TeacherID = @TeacherID;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@TeacherID", teacherID);
            command.Parameters.AddWithValue("@T_Name", t_Name);
            command.Parameters.AddWithValue("@T_Age", t_Age);
            command.Parameters.AddWithValue("@T_Contact", t_Contact);
            command.Parameters.AddWithValue("@H_Qualification", h_Qualification);
            command.Parameters.AddWithValue("@T_Experience", t_Experience);
            command.ExecuteNonQuery();
        }

        // DELETE
        public static void DeleteCourseRecord(string CourseID)
        {
            string qry = "delete from Courses where CourseID = " + CourseID + ";";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }

        public static void DeleteTeacherRecord(string TeacherID)
        {
            string qry = "delete from Teacher where TeacherID = " + TeacherID + ";";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }





        //internal static void UpdateCourseRecord(string CourseID, string C_Name, string c_CHours)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
