using System;

namespace BasicsAssignment
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1\n");
            Console.WriteLine("Enter any number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square Root : {0} ", Math.Sqrt(x));

            Console.WriteLine("\nPart 2");
            Random random = new Random();
            Console.WriteLine("Random Number : {0} ", random.Next(1, 10));
            Console.ReadLine();
         
        }
    }
}
