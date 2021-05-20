using System;
using System.IO;

namespace TemporaryTesting
{
    class App
    {
        static void Main()
        {
            string filepath = @"C:\Users\Bhupesh\Desktop\OneDrive_2020-10-24\Mini Project\Problem Statement\complaints.csv";

            string[] lines = File.ReadAllLines(filepath);

            foreach(string str in lines)
            {
                string[] column = str.Split(',');
                foreach(string col in column)
                {
                    Console.WriteLine(col);
                }
            }
            Console.ReadLine();

        }
    }
}
