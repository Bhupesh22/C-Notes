using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7CaseStudy
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;
        internal Enroll (Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

    }
}
