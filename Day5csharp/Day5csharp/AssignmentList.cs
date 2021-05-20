using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class EmployeeNew 
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string empcity { get; set; }
        public int salary { get; set; }

        public EmployeeNew(int empid, string empname, string empcity, int salary)
        {
            this.empid = empid;
            this.empname = empname;
            this.empcity = empcity;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Empid : " + empid + " Ename : " + empname + " Empcity : " + empcity + " Salary :" + salary;
        }

        /*public string CompareTo(EmployeeNew e)
        {
            return this.empid.CompareTo(e.empid);
        }*/

    }
    class AssignmentList
    {
        static void Main()
        {
            List<EmployeeNew> emp = new List<EmployeeNew>();
            emp.Add(new EmployeeNew(1, "Bhupesh", "Mumbai",20000));
            emp.Add(new EmployeeNew(3, "Rahul", "Pune",30000));
            emp.Add(new EmployeeNew(10, "Rishabh", "Banglore",40000));
            emp.Add(new EmployeeNew(90, "Rohan", "Delhi", 50000));
            emp.Add(new EmployeeNew(17, "Shyam", "Chennai", 60000));

            //First 
            foreach(EmployeeNew e in emp)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("------------------------------------------");
            //second
            foreach(EmployeeNew e in emp)
            {
                if(e.salary > 25000)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("------------------------------------------");
            //third
            foreach (EmployeeNew e in emp)
            {
                if(e.empcity == "Chennai")
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("------------------------------------------");
            //fourth
            emp.Sort((x,y)=>x.empname.CompareTo(y.empname));
            foreach (EmployeeNew e in emp)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
        
        
    }
}
