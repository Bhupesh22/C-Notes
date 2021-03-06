using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingProblems
{
    class BugFixing4
    {

			//A - array of 0s and 1s
			//need to return the starting position of first sequence of the maximal occurrences of 1s
			//return -1 in case if the array does not contains 1s
			int solution(int[] A)
			{
				int n = A.Length;
				int i = n - 1;
				int result = -1;
				int k = 0, maximal = 0;
				while (i > 0)
				{
					if (A[i] == 1)
					{
						k = k + 1;
						if (k >= maximal)
						{
							maximal = k;
							result = i;
						}
					}
					else
						k = 0;
					i = i - 1;
				}
				if (A[i] == 1 && k + 1 >= maximal)
				{
					result = 0;
				}
				return result;
			}

			public static void Main(string[] args)
			{
				int[] A = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 };
				Console.WriteLine(new BugFixing4().solution(A));
				Console.ReadLine();
			}
		}

	
}
