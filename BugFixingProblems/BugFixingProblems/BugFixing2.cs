using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingProblems
{
    class BugFixing2
    {
        public int solution(int[] A, int[] B)
        {
            int n = A.Length;
            int m = B.Length;
            Array.Sort(A);
            Array.Sort(B);
            int i = 0;
            for (int k = 0; k < n; k++)
            {
                while (i < m-1 && B[i] < A[k])
                    i += 1;
                if (A[k] == B[i])
                    return A[k];

            }
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] A = { 2, 4, 6, 7 , 8};
            int[] B = { 7, 1, 1, 8 };
            Console.WriteLine(new BugFixing2().solution(A, B));
            Console.ReadLine();
        }
    }
}
