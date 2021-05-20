using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace MiniProject
{
    class AppEngine
    {
        List<Complaint> complaint = LoadData.Load();

        public void ComplaintByYear(string year)
        {
            foreach (Complaint c in complaint)
            {
                string[] date = Regex.Split(c.DateReceived, "[/-]");
                if (date.Length == 3 && date[2] == year)
                {
                    Console.WriteLine($"Date : {c.DateReceived}\tProduct : {c.Product}\t Issue : {c.Issue}");
                }
            }
        }
        public void ComplaintByBank(string bank)
        {
            foreach( Complaint c in complaint)
            {
                if(c.Company == bank)
                {
                    Console.WriteLine($"Date : {c.DateReceived}\tProduct : {c.Product}\t Issue : {c.Issue}\t Bank Name :{c.Company}");
                }
            }
        }
        public void ComplaintById(string id)
        {
            foreach(Complaint c in complaint)
            {
                if(c.ComplaintID == id)
                {
                    Console.WriteLine($"Date : {c.DateReceived}\tProduct : {c.Product}\t Issue : {c.Issue}");
                }
            }
        }
        public void NumberOfDays()
        {
            foreach(Complaint c in complaint)
            {
                string d1 = c.DateReceived;
                string d2 = c.DateSent;
                int d1flag = -1;
                int d2flag = -1;
                if (d1.Contains("/"))
                {
                    d1flag = 1;
                }
                else if(d1.Contains("-"))
                {
                    d1flag = 0;
                }
                if (d2.Contains("/"))
                {
                    d2flag = 1;
                }
                else if (d2.Contains("-"))
                {
                    d2flag = 0;
                }

                DateTime date1 = GetDate(d1, d1flag);
                DateTime date2 = GetDate(d2, d2flag);
                try
                {
                    TimeSpan time = date2.Subtract(date1);
                    Console.WriteLine($"{c.Company}\t Total days : {time.TotalDays}");

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public void DisplayAllComplaintsClosed()
        {
            foreach(Complaint c in complaint)
            {
                if(c.CompanyResponse == "Closed with explanation")
                {
                    Console.WriteLine($"Date : {c.DateReceived}\tProduct : {c.Product}\t Issue : {c.Issue}");
                }
            }
        }
        public void TimelyResp()
        {
            foreach(Complaint c in complaint)
            {
                if(c.TimelyResponse.ToLower().Equals("yes"))
                {
                    Console.WriteLine($"Date : {c.DateReceived}\tProduct : {c.Product}\t Issue : {c.Issue}");
                }
            }
        }
        public void InsertData()
        {
            Console.WriteLine("Enter the details:");
            Console.WriteLine("1.Date received");
            string datereceived = Console.ReadLine();
            Console.WriteLine("2.Product");
            string product = Console.ReadLine();
            Console.WriteLine("3.Sub-product");
            string sub_product = Console.ReadLine();
            Console.WriteLine("4.Issue");
            string issue = Console.ReadLine();
            Console.WriteLine("5.Sub-issue");
            string sub_issue = Console.ReadLine();
            Console.WriteLine("6.Company");
            string company = Console.ReadLine();
            Console.WriteLine("7.State");
            string state = Console.ReadLine();
            Console.WriteLine("8.ZIP code");
            string zip = Console.ReadLine();
            Console.WriteLine("9. Submitted Via");
            string submitvia = Console.ReadLine();
            Console.WriteLine("10. Date Sent");
            string datesent = Console.ReadLine();
            Console.WriteLine("11.Company response to consumer");
            string company_response = Console.ReadLine();
            Console.WriteLine("12.Timely response?");
            string timely_respose = Console.ReadLine();
            Console.WriteLine("13.Consumer disputed?");
            string disputed = Console.ReadLine();
            Console.WriteLine("14.Complaint ID");
            string cid = Console.ReadLine();

            var csv = new StringBuilder();
            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}" +
                "", datereceived, product, sub_product, issue, sub_issue, company, state, zip, submitvia, datesent, company_response
                , timely_respose, disputed, cid);
            csv.AppendLine(newLine);
            File.AppendAllText(@"C:\Users\Bhupesh\Desktop\OneDrive_2020-10-24\Mini Project\Problem Statement\complaints.csv", csv.ToString());
            csv.Clear();
            csv.Clear();
        }
        public DateTime GetDate(string x, int f)
        {
            if(f == 1)
            {
                DateTime myDate = DateTime.ParseExact(x, "MM/dd/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                return myDate;
            }
            else
            {
                DateTime myDate = DateTime.ParseExact(x, "MM-dd-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                return myDate;
            }
        }
    }
}
