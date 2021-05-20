using System;


namespace Assignment1
{
    class ArrayPosition
    {
        static void Main()
        {
            int[] Data = { 6, 7, 9, 1, 4, 5 };
            Console.Write("Declared array is :");
            for(int i=0; i<Data.Length; i++)
            {
                Console.Write("{0} ", Data[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("Enter the element whose index you want to search ");
            int Element = Convert.ToInt32(Console.ReadLine());

            int Position = Array.IndexOf(Data, Element);
            Console.WriteLine("Index of {0} is {1}", Element, Position);
            
            Console.ReadLine();
        }
    }
}
