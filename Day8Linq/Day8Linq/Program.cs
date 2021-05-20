using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Linq
{
    class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public static List<Student> GetStudents()
        {
            List <Student> studentList= new List<Student>();
            Student s1 = new Student() { ID = 1, name = "Bhupesh" };
            Student s2 = new Student() { ID = 2, name = "Rahul" };
            Student s3 = new Student() { ID = 3, name = "Akshay" };
            Student s4 = new Student() { ID = 4, name = "Rishabh" };
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            return studentList;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] numbers = { 7, 99, 53, 49 };
            
            var result = from num in numbers
                         where num > 50
                         orderby num
                         select num.ToString();
            
            foreach(var res in result)
            {
                Console.Write(res+" ");
            }
            Console.WriteLine();

            List<string> strs = new List<string>() { "sam", "tam", "cook", "pam", "bam" };

            var resu = strs.Where(s => s.Contains("am")).ToList<string>();

            foreach(string i in resu)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var even = from n in nums
                       where n % 2 == 0
                       select n;
            foreach(var eve in even)
            {
                Console.Write(eve + " ");
            }*/
            IEnumerable<string> queryName = from stud in Student.GetStudents()
                                            where stud.name.ToLower().StartsWith("b")
                                            //where stud.ID == 2
                                            select stud.name;
            foreach(var s in queryName)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
