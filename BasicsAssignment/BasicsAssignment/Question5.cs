using System;

namespace BasicsAssignment
{
    class Question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Birthdate : (dd/mm/yyyy) ");
            string[] date = Console.ReadLine().Split('/');
            
            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);

            DateTime birth = new DateTime(year, month, day);
            DateTime today = DateTime.Now;

            TimeSpan difference = today - birth;

            DateTime age = DateTime.MinValue.AddDays(difference.Days);
            Console.WriteLine("Age is : {0} years, {1} months, {2} days ", age.Year - 1, age.Month - 1, age.Day - 1);
            Console.ReadLine();

        }
    }
}
