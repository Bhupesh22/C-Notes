using System;


namespace FirstApplicationProgram
{
    class BoxingUnboxing
    {
        static void Main()
        {
            int Data = 10;

            object Obj = Data; //Boxing 

            int j = Convert.ToInt32(Obj); //Unboxing

            //or

            int g = (int)Obj;

            Console.WriteLine(j);
            Console.WriteLine(g);
            Console.ReadKey();


        }
    }
}
