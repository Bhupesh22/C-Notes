using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7CaseStudy
{
    class Course
    {
        public int courseid { get; set; }
        public string coursename { get; set; }
        public int duration { get; set; }
        public int fees { get; set; }
        internal Course(int courseid, string coursename, int duration, int fees)
        {
            this.courseid = courseid;
            this.coursename = coursename;
            this.duration = duration;
            this.fees = fees;
        }
        public override string ToString()
        {
            return courseid + "\t" + coursename + "\t" + duration + "\t" + fees;
        }
    }
}
