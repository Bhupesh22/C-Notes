using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5csharp
{
    class Employee : IComparable<Employee>
    {
        int empid;
        string name; 
        string company;
        float salary;

        public Employee(int empid, string name, string company)
        {
            this.empid = empid;
            this.name = name;
            this.company = company;
        }
        public override string ToString()
        {
            return empid + " " + name + " " + company;
        }
        public int CompareTo(Employee e)
        {
            return this.empid - e.empid;
        }
    }
    class UserDefinedGenerics
    {
        static void Main()
        {
            List <Employee> emps = new List<Employee>();
            emps.Add(new Employee(1, "Bhupesh", "LTI"));
            emps.Add(new Employee(3, "Rahul", "LTI"));
            emps.Add(new Employee(10, "Rishabh", "LTI"));
            emps.Add(new Employee(90, "Rohan", "LTI"));
            emps.Add(new Employee(17, "Shyam", "LTI"));

            foreach(Employee e in emps)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("After Sorting");
            emps.Sort();
            foreach (Employee e in emps)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();
        }
    }
}
