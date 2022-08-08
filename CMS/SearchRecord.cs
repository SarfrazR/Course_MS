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
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
            lblID.Hide();
            txtCID.Hide();
            txtTID.Hide();
            lblTID.Hide();
            cmbDCID.Hide();
            cmbDTID.Hide();
            btnDoneCD.Hide();
            btnDoneTD.Hide();
        }

        private void btnRtnM1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSCourse_Click(object sender, EventArgs e)
        {
            txtCID.Show();
            lblID.Show();
            txtTID.Hide();
            lblTID.Hide();
            cmbDCID.Show();
            cmbDTID.Hide();

            btnDoneCD.Show();
            btnDoneTD.Hide();
        }

        private void btnSTeachers_Click(object sender, EventArgs e)
        {
            txtTID.Show();
            lblTID.Show();
            txtCID.Hide();
            lblID.Hide();
            cmbDTID.Show();
            cmbDCID.Hide();

            btnDoneCD.Hide();
            btnDoneTD.Show();
        }

        private void btnDoneCD_Click(object sender, EventArgs e)
        {
            string C_id=txtCID.Text;
            DataAccessLayer.SearchCourse(C_id);

        }

        private void btnDoneTD_Click(object sender, EventArgs e)
        {
            string T_id=txtTID.Text;
            DataAccessLayer.SearchTeacher(T_id);
        }
    }
}
