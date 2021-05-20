/*using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryTesting
{
    class Program
    {
        static List<Complaints> LoadData()
        {
            string filepath = @"C:\Users\Bhupesh\Desktop\OneDrive_2020-10-24\Mini Project\Problem Statement\complaints.csv";
            List<Complaints> complaints = new List<Complaints>();
            using (var reader = new StreamReader(filepath))
            { 
                var header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    //complaints.Add(new Complaints(data[0], data[1], data[2], data[3], data[4], data[5], data[6], int.Parse(data[7]), data[8], data[9], data[10], data[11], data[12], int.Parse(data[13])));
                    
                }
            }
            return complaints;
        }
        static void Main(string[] args)
        {
            List<Complaints> complaints = LoadData();
            /*for(int i=0; i<5; i++)
            {
                Console.WriteLine(complaints[i].ToString());
     
            
    }
}
*/