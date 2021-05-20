using System;
namespace Codility
{
    class Circle
    {
        public static void Main(String[] args)
        {
            /* int inner = 1;
             int outer = 3;
             int[] points_x = { 0, 1, 2, -2, 3 };
             int[] points_y = { 0, 1, 4, 1, 0 }; */
            /*
             int inner = 2;
             int outer = 5;
             int[] points_x = { 0, -1, -2, 4, 5 };
             int[] points_y = { 5, 0, 1, -4, 0 }; */

            int inner = 1;
            int outer = 3;
            int[] points_x = { 2, 1, -2, -2, 5 };
            int[] points_y = { 1, 1, 1, -2, 0 };

            int result = Solution(inner, outer, points_x, points_y);
            Console.WriteLine(result);
            Console.Read();
        }

        static int Solution(int inner, int outer, int[] points_x, int[] points_y)
        {
            int count = 0;
            int r1 = inner * inner;
            int r2 = outer * outer;
            for (int i = 0; i < points_x.Length; i++)
            {
                int x = (points_x[i] * points_x[i]) + (points_y[i] * points_y[i]);
                if (r1 < x && x < r2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
