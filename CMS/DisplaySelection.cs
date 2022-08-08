using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class DisplaySelection : Form
    {
        public DisplaySelection()
        {
            InitializeComponent();
            cmbACR.Hide();
        }

        private void lblDSelection_Click(object sender, EventArgs e)
        {

        }

        private void btnRtnM_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDCourse_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = DataAccessLayer.GetCourseData();
            string result="";
            while (reader.Read())
            {
                string course_Id = reader["CourseID"].ToString();
                string c_Name = reader["C_Name"].ToString();
                string c_Hours = reader["C_CHours"].ToString();
                result += string.Format("{0}\t\t{1}\t\t{2}", course_Id, c_Name, c_Hours);
                cmbACR.Items.Add(result);
                cmbACR.Show();
                cmbATR.Hide();
            }
        }

        private void btnDTeachers_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = DataAccessLayer.GetTeacherData();
            string result="";
            while (reader.Read())
            {
                string teacher_Id = reader["TeacherID"].ToString();
                string t_Name = reader["T_Name"].ToString();
                string t_Age = reader["T_Age"].ToString();
                string t_Contact = reader["T_Contact"].ToString();
                string h_Qualification = reader["H_Qualification"].ToString();
                string t_Experience = reader["T_Experience"].ToString();
                result += string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", teacher_Id, t_Name, t_Age, h_Qualification, t_Experience, t_Contact);
                cmbATR.Items.Add(result);

            }
            cmbATR.Show();
            cmbACR.Hide();
        }

        
    }
}
