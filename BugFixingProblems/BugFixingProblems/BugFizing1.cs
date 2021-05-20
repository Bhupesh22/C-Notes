using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingProblems
{
    class BugFixing1
    {
        public String solution(string S)
        {
            int[] occurrences = new int[26];
            foreach (char ch in S)
            {
                occurrences[(int)ch - 'a']++;
            }

            char best_char = 'a';
            int best_res = 0;

            for (int i = 0; i < 26; i++)
            {
                if (occurrences[i] > best_res)
                {
                    best_char = (char)(('a' + i));
                    best_res = occurrences[i];
                }
            }

            return best_char.ToString();
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(new BugFixing1().solution("apple"));
            Console.WriteLine(new BugFixing1().solution("hello"));
            Console.WriteLine(new BugFixing1().solution("parameter"));
            Console.ReadLine();
        }
    }
}
