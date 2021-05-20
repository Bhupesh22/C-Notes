using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingProblems
{
    class BugFixing3
    {
		//check if the array contains every number from 1 to K atleast once
		public bool solution(int[] A, int K)
		{
			int n = A.Length;
			for (int i = 0; i < n -1 && A[i] < K ; i++)
			{
				if (A[i] + 1 < A[i + 1])
					return false;
			}
			if (A[0] != 1 && A[n - 1] != K)
				return false;
			else
				return true;
		}

		public static void Main(string[] args)
		{
			int[] A = {4, 1, 3, 2};
			int K = 4;
			Console.WriteLine(new BugFixing3().solution(A, K));
			Console.ReadLine();
		}
	}
}
