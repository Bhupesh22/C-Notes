using System;


namespace Assignment1
{
    class StudentGrade
    {
        enum grades { F, D, C, B, A};
        static void Main()
        {
            Console.WriteLine("Enter Marks in English (/100)");
            float English = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Marks in Maths (/100)");
            float Maths = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Marks in Science(/100)");
            float Science = Convert.ToSingle(Console.ReadLine());

            float Avg = (English + Maths + Science) / 3;

            Console.WriteLine("Average Score is :{0:f3}", Avg);

            int Rating = 0;
            if(Avg >= 85)
            {
                Rating = 4;
            }else if (Avg >= 75 && Avg < 85)
            {
                Rating = 3;
            }else if (Avg >= 60 && Avg < 75)
            {
                Rating = 2;
            }else if (Avg >=50 && Avg < 60)
            {
                Rating = 1;
            }

            //to get the enum from index 
            Console.WriteLine("Grade of the student is : {0}", (grades) Rating);
            Console.ReadLine();

        }
    }
}
