using System;

namespace BasicsAssignment
{
    class Question10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number :");
            int x = Convert.ToInt32(Console.ReadLine());
            
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string res = "";

            int i = 0;
            while (x > 0)
            {
                while (x >= values[i])
                {
                    x = x - values[i];
                    res += roman[i];
                }
                i++;
            }
            Console.WriteLine("Roman Equivalent :{0} ", res);
            Console.ReadLine();
        }
    }
}
