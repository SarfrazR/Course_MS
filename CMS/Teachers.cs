using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            lblAddAge.Hide();
            lblAddCnt.Hide();
            lblAddExp.Hide();
            lblAddQual.Hide();
            lblAddT_ID.Hide();
            lblAddTName.Hide();
            txtAddAge.Hide();
            txtAddCnt.Hide();
            txtAddExp.Hide();
            txtAddQual.Hide();
            txtAddT_ID.Hide();
            txtAddT_Name.Hide();
            lblDelT_ID.Hide();
            txtDelT_ID.Hide();
            lblUpdAge.Hide();
            lblUpdCnt.Hide();
            lblUpdExp.Hide();
            lblUpdQual.Hide();
            lblUpdT_ID.Hide();
            lblUpdT_Name.Hide();
            txtUpdAge.Hide();
            txtUpdCnt.Hide();
            txtUpdExp.Hide();
            txtUpdQual.Hide();
            txtUpdT_ID.Hide();
            txtUpdT_Name.Hide();
            btnDoneAT.Hide();
            btnDoneDT.Hide();
            btnDoneTU.Hide();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAddTRec_Click(object sender, EventArgs e)
        {
            lblAddAge.Show();
            lblAddCnt.Show();
            lblAddExp.Show();
            lblAddQual.Show();
            lblAddT_ID.Show();
            lblAddTName.Show();
            txtAddAge.Show();
            txtAddCnt.Show();
            txtAddExp.Show();
            txtAddQual.Show();
            txtAddT_ID.Show();
            txtAddT_Name.Show();
            lblDelT_ID.Hide();
            txtDelT_ID.Hide();
            lblUpdAge.Hide();
            lblUpdCnt.Hide();
            lblUpdExp.Hide();
            lblUpdQual.Hide();
            lblUpdT_ID.Hide();
            lblUpdT_Name.Hide();
            txtUpdAge.Hide();
            txtUpdCnt.Hide();
            txtUpdExp.Hide();
            txtUpdQual.Hide();
            txtUpdT_ID.Hide();
            txtUpdT_Name.Hide();
            btnDoneAT.Show();
            btnDoneDT.Hide();
            btnDoneTU.Hide();
        }

        private void btnDelTRec_Click(object sender, EventArgs e)
        {
            lblAddAge.Hide();
            lblAddCnt.Hide();
            lblAddExp.Hide();
            lblAddQual.Hide();
            lblAddT_ID.Hide();
            lblAddTName.Hide();
            txtAddAge.Hide();
            txtAddCnt.Hide();
            txtAddExp.Hide();
            txtAddQual.Hide();
            txtAddT_ID.Hide();
            txtAddT_Name.Hide();
            lblDelT_ID.Show();
            txtDelT_ID.Show();
            lblUpdAge.Hide();
            lblUpdCnt.Hide();
            lblUpdExp.Hide();
            lblUpdQual.Hide();
            lblUpdT_ID.Hide();
            lblUpdT_Name.Hide();
            txtUpdAge.Hide();
            txtUpdCnt.Hide();
            txtUpdExp.Hide();
            txtUpdQual.Hide();
            txtUpdT_ID.Hide();
            txtUpdT_Name.Hide();
            btnDoneAT.Hide();
            btnDoneDT.Show();
            btnDoneTU.Hide();
        }

        private void btnUpdTRec_Click(object sender, EventArgs e)
        {
            lblAddAge.Hide();
            lblAddCnt.Hide();
            lblAddExp.Hide();
            lblAddQual.Hide();
            lblAddT_ID.Hide();
            lblAddTName.Hide();
            txtAddAge.Hide();
            txtAddCnt.Hide();
            txtAddExp.Hide();
            txtAddQual.Hide();
            txtAddT_ID.Hide();
            txtAddT_Name.Hide();
            lblDelT_ID.Hide();
            txtDelT_ID.Hide();
            lblUpdAge.Show();
            lblUpdCnt.Show();
            lblUpdExp.Show();
            lblUpdQual.Show();
            lblUpdT_ID.Show();
            lblUpdT_Name.Show();
            txtUpdAge.Show();
            txtUpdCnt.Show();
            txtUpdExp.Show();
            txtUpdQual.Show();
            txtUpdT_ID.Show();
            txtUpdT_Name.Show();
            btnDoneAT.Hide();
            btnDoneDT.Hide();
            btnDoneTU.Show();
        }

        private void btnDoneAT_Click(object sender, EventArgs e)
        {
            string TID=txtAddT_ID.Text;
            string T_Name=txtAddT_Name.Text; 
            int T_Age=int.Parse(txtAddAge.Text);
            string T_Contact=txtAddCnt.Text;
            string H_Qual=txtAddQual.Text;
            int T_Expe=int.Parse(txtAddExp.Text);
            DataAccessLayer.AddTeacherRecord(TID, T_Name, T_Age, T_Contact, H_Qual, T_Expe);
            MessageBox.Show("Data Added");
        }

        private void btnDoneDT_Click(object sender, EventArgs e)
        {
            string teacherID=txtDelT_ID.Text;
            DataAccessLayer.DeleteTeacherRecord(teacherID);
            MessageBox.Show("Data Deleted");
        }

        private void btnDoneTU_Click(object sender, EventArgs e)
        {
            string TID=txtAddT_ID.Text;
            string T_Name=txtAddT_Name.Text; 
            int T_Age=int.Parse(txtAddAge.Text);
            string T_Contact=txtAddCnt.Text;
            string H_Qual=txtAddQual.Text;
            int T_Expe=int.Parse(txtAddExp.Text);
            DataAccessLayer.UpdateTeacherRecord(TID, T_Name, T_Age, T_Contact, H_Qual, T_Expe);
            MessageBox.Show("Data Updated");
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }
    }
}
