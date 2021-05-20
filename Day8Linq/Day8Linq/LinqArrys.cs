using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Linq
{
    class StudentNew
    {
        public int roll { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string gender { get; set; }

        public StudentNew(int roll, string name, string city, string gender)
        {
            this.roll = roll;
            this.name = name;
            this.city = city;
            this.gender = gender;
        }

    }
    class LinqArrys
    {
        string[] books = { "c#","Java", "CPP", "DBMS", "Networking" };
        static int[] marks = { 90, 98, 87, 76, 90, 100 };

        #region String Operation


        #endregion

        #region IntOpertion

        static void IntArrays()
        {
            Console.WriteLine("Minimum Marks :{0}", marks.Min());

            IEnumerable<int> mark = from m in marks
                                     where m > 80 && m < 100
                                     select m;
            Console.WriteLine("\n---------------------------------------\n");
            foreach (var mar in mark)
            {
                Console.Write(mar + " ");
            }
            Console.WriteLine();

            //to count
            int count = (from m in marks
                         where m > 80 && m < 100
                         select m).Count();
            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("Count : {0}", count);
        }

        #endregion

        public void workWithList()
        {
            List<StudentNew> studs = new List<StudentNew>();
            StudentNew s1 = new StudentNew(1, "Bhupesh", "Mumbai", "Male");
            StudentNew s2 = new StudentNew(2, "Rahul", "Mumbai", "Male");
            StudentNew s3 = new StudentNew(3, "Rishabh", "Delhi", "Male");
            StudentNew s4 = new StudentNew(4, "Jayesh", "Mumbai", "Male");
            StudentNew s5 = new StudentNew(5, "Akshay", "Pune", "Male");

            studs.Add(s1);
            studs.Add(s2);
            studs.Add(s3);
            studs.Add(s4);
            studs.Add(s5);

            var studcity = from stud in studs
                           where stud.city.Equals("Mumbai")
                           select stud.name;
            Console.WriteLine("\n---------------------------------------\n");
            foreach (var s in studcity)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();


        }

        //GroupBy and OrderBy
        void orderGroup()
        {
            List<StudentNew> studs = new List<StudentNew>();
            StudentNew s1 = new StudentNew(1, "Ram", "Mumbai", "Male");
            StudentNew s2 = new StudentNew(2, "Shyam", "Mumbai", "Male");
            StudentNew s3 = new StudentNew(3, "Rishabh", "Delhi", "Male");
            StudentNew s4 = new StudentNew(4, "Arnab", "Mumbai", "Male");
            StudentNew s5 = new StudentNew(5, "Akshay", "Pune", "Male");
            StudentNew s6 = new StudentNew(6, "Prachi", "Pune", "Female");
            studs.Add(s1);
            studs.Add(s2);
            studs.Add(s3);
            studs.Add(s4);
            studs.Add(s5);
            studs.Add(s6);

            IEnumerable<StudentNew> stud = from st in studs
                                           orderby st.name, st.gender
                                           select st;

            foreach(var student in stud)
            {
                Console.WriteLine(student.name + " " + student.city);
            }

            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("Number of male and female");

            var genderCount = from st in stud
                              group st by st.gender;
            //gender count will have collection (key, count)
            foreach(var g in genderCount)
            {
                Console.Write(g.Key + " : " + g.Count());
            }

        }
        static void Main()
        {
            LinqArrys LA = new LinqArrys();
            IntArrays(); //Static method
            LA.workWithList();
            LA.orderGroup();
            Console.Read();
            
        }
        
    }

    
}
