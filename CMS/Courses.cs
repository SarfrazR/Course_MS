using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL
{
    class Courses
    {
        public string CourseID { get; set; }
        public string C_Name { get; set; }
        public int C_CHours { get; set; }
        public Courses(string cid,string cname,int hours)
        {
            CourseID = cid;
            C_Name = cname;
            C_CHours = hours;
        }
    }
}
