using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7CaseStudy
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        internal Student(int ID, string Name, string DateOfBirth)
        {
            this.ID = ID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
        public override string ToString()
        {
            return ID + "\t" + Name + "\t" + DateOfBirth;
        }
    }
}
