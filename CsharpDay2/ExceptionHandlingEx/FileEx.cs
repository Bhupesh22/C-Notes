using System;
using System.IO;

namespace ExceptionHandlingEx
{
    class FileEx
    {
        static void Main()
        {
            FileStream fs = new FileStream("C:\\Users\\Bhupesh\\Desktop\\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                Console.WriteLine("Enter the test");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
