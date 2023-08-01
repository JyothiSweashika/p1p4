using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1p4
{
    public class TeacherWithSubjects
    {
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }

        public TeacherWithSubjects()
        {
            Subjects = new List<Subject>();
        }

    }
}
