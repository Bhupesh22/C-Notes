using System;

namespace BasicsAssignment
{
    class Question1
    {
        public static void getBinary(int x)
        {
            int[] bin = new int[32];
            int i = 0;
            while (x > 0)
            {
                bin[i] = x % 2;
                x = x / 2;
                i++;
            }
            Console.Write("Binary Equivalent : ");
            for(int j = i-1; j>=0; j--)
            {
                Console.Write("{0}", bin[j]);
            }
        }
        public static void getOctal(int x)
        {
            int[] octal = new int[100];
            int i = 0;
            while(x > 0)
            {
                octal[i] = x % 8;
                x = x / 8;
                i++;
            }
            Console.Write("Octal Equivalent : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", octal[j]);
            }
        }
        public static void getHexa(int x)
        {
            char[] hexa = new char[100];
            int i = 0;
            while(x > 0){
                int temp = x % 16;
                if(temp < 10)
                {
                    hexa[i] = (char)(temp + 48);
                }
                else
                {
                    hexa[i] = (char)(temp + 55);
                }
                x = x / 16;
                i++;
            }
            Console.Write("HexaDecimal Equivalent : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", hexa[j]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number : ");
            int x = Convert.ToInt32(Console.ReadLine());
         
            getBinary(x);
            Console.WriteLine();
            
            getOctal(x);
            Console.WriteLine();
            
            getHexa(x);
            Console.ReadLine();

        }
    }
}
