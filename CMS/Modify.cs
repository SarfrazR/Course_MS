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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            
        }

        private void btnMCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
        }

        private void btnMTeachers_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            teacher.Show();

        }

        private void btnRtnM1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
