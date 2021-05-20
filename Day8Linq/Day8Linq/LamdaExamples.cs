using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day8Linq
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
    class LamdaExamples
    {
        static void Main()
        {
            List<int> nums = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            //display
            Console.WriteLine("Display");
            Console.WriteLine("\n--------------------------------------------------\n");
            foreach(var num in nums)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            //lambda
            //square

            var square = nums.Select(x => x * x);
            Console.WriteLine("Square");
            Console.WriteLine("\n--------------------------------------------------\n");
            foreach (var num in square)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            //Divisible by 3
            var div = nums.FindAll(x => x % 3 == 0 ? true : false);

            Console.WriteLine("Divisible by 3");
            Console.WriteLine("\n--------------------------------------------------\n");
            foreach (var num in div)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("\n--------------------------------------------------\n");

            List<Employee> empList = new List<Employee>()
            {
                new Employee(1,"Bhupesh" ),
                new Employee(2,"Rahul" ),
                new Employee(3,"Manish"),
                new Employee(4,"Dinesh" ),
                new Employee(5,"Zoya"),

            };

            Employee e = empList.Find(x => x.id == 2);
            Console.WriteLine(e.id + " " + e.name);
            Console.WriteLine("\n--------------------------------------------------\n");
            var empsort = empList.OrderBy(x => x.name);
            foreach(var v in empsort)
            {
                Console.Write("{0} {1}", v.id, v.name);
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            Console.ReadLine();

        }
    }
}
