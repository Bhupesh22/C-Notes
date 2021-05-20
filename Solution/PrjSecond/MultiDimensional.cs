using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PrjSecond
{
    class MultiDimensional
    {
        static void Main()
        {
            int[,] Mat = new int[3,3]; //2D Syntax
            //int[,,] ThreeD = new int[3,3,3] //3D

            Console.WriteLine("Enter the Matrix Elements :");
            for(int i=0; i<Mat.GetLength(0); i++)
            {
                for(int j=0; j<Mat.GetLength(1); j++)
                {
                    Console.Write("Enter value for ({0},{1}) : ", i, j);
                    Mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Entered Matrix is :");
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    Console.Write("{0} ", Mat[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
