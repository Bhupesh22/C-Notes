using System;
using System.Linq;

namespace Assignment2New
{
    class Question2
    {
        static string SecretWord;

        static int Chances;
        static void Main()
        {
            Console.WriteLine("Player 1 : Enter the word :");
            SecretWord = Console.ReadLine();

            SecretWord = SecretWord.ToLower();

            int Bulls = 0, Cows = 0;

            int[] Counter = new int[26];
            int[] Result = new int[26];
            int Flag = 0;
            
            for (int i = 0; i < SecretWord.Length; i++)
            {
                Counter[SecretWord[i] - 'a']++;
            }

            Console.WriteLine("Player 1 : Enter the chances you want to give to player 2 :");
            Chances = Convert.ToInt32(Console.ReadLine());

            if (Chances < SecretWord.Length)
            {
                Console.WriteLine("Please give chances more than length !!!");
            }
            else
            {
                Console.WriteLine("\n------------------- Game Begins -------------------\n");
                while (Chances != 0)
                {
                    Console.WriteLine("Player 2 : Enter Character (Remaining Chances :{0})", Chances);
                    char ch = Console.ReadLine()[0];
                    ch = Char.ToLower(ch);

                    if (SecretWord.Contains(ch) && Counter[ch - 'a'] != 0)
                    {
                        Console.WriteLine("Your Guess is correct ");
                        Counter[ch - 'a']--;
                        Bulls++;
                    }
                    else
                    {
                        Console.WriteLine("OOPS ! Wrong guess");
                        Cows++;
                    }
                    if (Counter.SequenceEqual(Result))
                    {
                        Flag = 1;
                        break;
                    }

                    Chances--;
                }
                if (!(Counter.SequenceEqual(Result)) && Flag == 0)
                {
                    Console.WriteLine("\nPlayer 2: You Lost !!! Try Again Later . . .\n");
                }
                else
                {
                    Console.WriteLine("\nPlayer 2 correctly guessed\n");
                }
                Console.WriteLine("-------------------------Final Score -------------------------------");
                Console.WriteLine("Bulls : {0}", Bulls);
                Console.WriteLine("Cows : {0}", Cows);

            }
            Console.ReadLine();

        }
    }
}
