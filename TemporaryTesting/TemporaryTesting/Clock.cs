using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryTesting
{
    class Clock
    {
        static void Main()
        {
            int[] nums = { 1, 8, 3, 2 };
            IList<IList<int>> returnable = new List<IList<int>>();
            PermuteHelper(nums.ToList(), new List<int>(), returnable);
            foreach(List<int> x in returnable)
            {
                foreach(int y in x)
                {
                    Console.Write("{0} ", y);
                }
                Console.WriteLine();
            }
            
        }
        static void PermuteHelper(List<int> nums, List<int> choose, IList<IList<int>> result)
        {
            if (nums.Count == 0)
            {
                result.Add(choose.ToArray());
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    choose.Add(nums[i]);
                    PermuteHelper(nums, choose, result);
                    choose.Remove(nums[i]);
                }
            }
        }
}
