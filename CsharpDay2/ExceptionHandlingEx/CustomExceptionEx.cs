using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEx
{
    public class AgeNotValidException : ApplicationException
    {
        public AgeNotValidException(string Message ):base(Message)
        {

        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        internal Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        internal void CheckAge()
        {
            
            try
            {
                if (Age < 20)
                {
                    Console.WriteLine("Registered");
                }
                else
                {
                    throw new AgeNotValidException("Age should be less than 20");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class CustomExceptionEx
    {
        static void Main()
        {
            Student student = new Student("Bhupesh", 30);
            student.CheckAge();
            Console.ReadLine();
        }
        
        

    }
}
