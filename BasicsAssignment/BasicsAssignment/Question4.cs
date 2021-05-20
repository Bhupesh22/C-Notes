using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsAssignment
{
    class Question4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Day :");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month :");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine("\nDay of Week is {0}",dateTime.DayOfWeek);
            Console.ReadLine();

        }
    }
}
