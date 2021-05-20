using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the portal\n");
            AppEngine app = new AppEngine();
            do
            {
                Console.WriteLine(" 1.Details Based on year \n 2.Details Based on Bank \n 3.Details on Id \n "
                    + "4.Display No.of Days \n 5.Display Complaints closed \n "
                    + "6.Display Complaints With Timely response \n 7.Insert \n 8.Exit \n");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch){
                    case 1: Console.WriteLine("Enter Year :");
                            string year = Console.ReadLine();
                            app.ComplaintByYear(year);
                            break;
                    
                    case 2: Console.WriteLine("Enter Bank Name :");
                            string bank = Console.ReadLine();
                            app.ComplaintByBank(bank);
                            break;
                    
                    case 3: Console.WriteLine("Enter Complaint ID :");
                            string id = Console.ReadLine();
                            app.ComplaintById(id);
                            break;
                    
                    case 4: app.NumberOfDays();
                            break;
                    
                    case 5: app.DisplayAllComplaintsClosed();
                            break;
                    
                    case 6: app.TimelyResp() ;
                            break;

                    case 7: app.InsertData();
                            break;
                    case 8: Environment.Exit(0);
                            break;
                            
                }
            } while (true);
        }
    }
}
