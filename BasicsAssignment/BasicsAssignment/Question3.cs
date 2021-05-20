using System;

namespace BasicsAssignment
{
    class Question3
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("New York Time : {0}",
                  TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Eastern Standard Time"));
            Console.ReadLine();
        }
    }
}
