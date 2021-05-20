using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    class JaggedArray
    {
        static void Main()
        {
            int i, j;
            //Jagged Array
            int[][] Table = new int[3][];
            Table[0] = new int[3];
            Table[1] = new int[2];
            Table[2] = new int[3];
            for(i=0; i<Table.Length; i++)
            {
                for(j=0; j<Table[i].Length; j++)
                {
                    Console.Write("Enter value for ({0},{1}) : ", i, j);
                    Table[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged Array is : ");
            for(i=0; i<Table.Length; i++)
            {
                Console.Write("\n");
                for (j=0; j<Table[i].Length; j++)
                {
                 
                    Console.Write("{0} ", Table[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
