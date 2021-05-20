using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MiniProject
{
    class LoadData
    {
        public static List<Complaint> Load()
        {
            string filepath = @"C:\Users\Bhupesh\Desktop\OneDrive_2020-10-24\Mini Project\Problem Statement\complaints.csv";

            var reader = new StreamReader(File.OpenRead(filepath));
            List<Complaint> coms = new List<Complaint>();
            var heading = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string splitter = "(?x)   " +
                     ",          " +   // Split on comma
                     "(?=        " +   // Followed by
                     "  (?:      " +   // Start a non-capture group
                     "    [^\"]* " +   // 0 or more non-quote characters
                     "    \"     " +   // 1 quote
                     "    [^\"]* " +   // 0 or more non-quote characters
                     "    \"     " +   // 1 quote
                     "  )*       " +   // 0 or more repetition of non-capture group (multiple of 2 quotes will be even)
                     "  [^\"]*   " +   // Finally 0 or more non-quotes
                     "  $        " +   // Till the end  (This is necessary, else every comma will satisfy the condition)
                     ")";  
                String[] data = Regex.Split(line, splitter);

                for (int i=0; i<data.Length; i++)
                {
                    if(data[i].Length == 0|| data[i] == "" ||data[i].Equals(""))
                    {
                        data[i] = "Not Available";
                    }
                }
                //Console.WriteLine("\nData Length: {0}\n",data.Length);
                /*for(int i=0; i<data.Length; i++)
                {
                    Console.Write("{0} * ", data[i]);
                }*/
                //Console.WriteLine();
                Complaint comp = new Complaint(data[0], data[1], data[2], data[3],
                    data[4], data[5], data[6], data[7], data[8], data[9],
                    data[10], data[11], data[12], data[13]);
                coms.Add(comp);
                
            }
            return coms;

        }
    }
}
