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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection connection = DataAccessLayer.GetConnection();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplaySelection Selection = new DisplaySelection();
            Selection.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecord search = new SearchRecord();
            search.Show();
            

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.Show();
           
        }
    }
}
