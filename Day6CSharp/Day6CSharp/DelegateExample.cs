using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6CSharp
{
    public delegate void EmpDel(string ename); //Declaration
    class Employee
    {
        public static void Accept(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }
        public int getSalary(int sal)       //this will not match delegate 
        {
            return 0;
        }
        public void Display(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class DelegateExample
    {
        static void Main()
        {
            Employee emp = new Employee();
            
            EmpDel eda = new EmpDel(Employee.Accept); //static method so classname is used
            eda("Bhupesh");
            
            EmpDel edd = new EmpDel(emp.Display); //non static so instance is used
            edd("Welcome to C# delegates");
            
            Console.Read();
        }
    }
}
