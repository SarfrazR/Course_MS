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
using CMS;

namespace CMS
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            txtAddC_Name.Hide();
            txtAddC_Hours.Hide();
            txtAddC_ID.Hide();
            lblAddC_ID.Hide();
            lblAddCHours.Hide();
            lblAddCName.Hide();
            lblDelC_ID.Hide();
            txtDelC_ID.Hide();
            lblUpdC_ID.Hide();
            txtUpdC_ID.Hide();
            lblUpdC_Name.Hide();
            lblUpdC_Hours.Hide();
            txtUpdC_Name.Hide();
            txtUpdC_hours.Hide();
            btnDoneAdd.Hide();
            btnDoneUpd.Hide();
            btnDoneDel.Hide();
        }

        private void btnAddCRec_Click(object sender, EventArgs e)
        {
            
                txtAddC_Name.Show();
                txtAddC_Hours.Show();
                txtAddC_ID.Show();
                lblAddC_ID.Show();
                lblAddCHours.Show();
                lblAddCName.Show();
                lblDelC_ID.Hide();
                txtDelC_ID.Hide();
                lblUpdC_ID.Hide();
                txtUpdC_ID.Hide();
                lblUpdC_Name.Hide();
                lblUpdC_Hours.Hide();
                txtUpdC_Name.Hide();
                txtUpdC_hours.Hide();
                btnDoneAdd.Show();
                btnDoneDel.Hide();
                btnDoneUpd.Hide();
        }

        private void btnDelTRec_Click(object sender, EventArgs e)
        {
            txtDelC_ID.Show();
            lblDelC_ID.Show();
            txtAddC_Name.Hide();
            txtAddC_Hours.Hide();
            txtAddC_ID.Hide();
            lblAddC_ID.Hide();
            lblAddCHours.Hide();
            lblAddCName.Hide();
            lblUpdC_ID.Hide();
            txtUpdC_ID.Hide();
            lblUpdC_Name.Hide();
            lblUpdC_Hours.Hide();
            txtUpdC_Name.Hide();
            txtUpdC_hours.Hide();
            btnDoneDel.Show();
            btnDoneAdd.Hide();
            btnDoneUpd.Hide();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnUpdCRec_Click(object sender, EventArgs e)
        {
            lblUpdC_ID.Show();
            txtUpdC_ID.Show();
            txtAddC_Name.Hide();
            txtAddC_Hours.Hide();
            txtAddC_ID.Hide();
            lblAddC_ID.Hide();
            lblAddCHours.Hide();
            lblAddCName.Hide();
            lblDelC_ID.Hide();
            txtDelC_ID.Hide();
            lblUpdC_Name.Show();
            lblUpdC_Hours.Show();
            txtUpdC_Name.Show();
            txtUpdC_hours.Show();
            btnDoneUpd.Show();
            btnDoneAdd.Hide();
            btnDoneDel.Hide();
        }

        private void btnDoneAdd_Click(object sender, EventArgs e)
        {

            string CourseID = txtAddC_ID.Text;
            string C_Name = txtAddC_Name.Text;
            string c_CHours = txtAddC_Hours.Text;
            DataAccessLayer.AddCourseRecord(CourseID, C_Name, c_CHours);
            MessageBox.Show("Data Added");
        }

        private void btnDoneDel_Click(object sender, EventArgs e)
        {
            string C_ID=txtDelC_ID.Text;
            DataAccessLayer.DeleteCourseRecord(C_ID);
            MessageBox.Show("Record Deleted!");
        }

        private void btnDoneUpd_Click(object sender, EventArgs e)
        {
            string CourseID = txtAddC_ID.Text;
            string C_Name = txtAddC_Name.Text;
            string c_CHours = txtAddC_Hours.Text;
            DataAccessLayer.UpdateCourseRecord(CourseID, C_Name, c_CHours);
            MessageBox.Show("Data Updated!");
        }
    }
}
