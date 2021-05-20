using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingProblems
{
    class newemailnew
    {
        static void Main()
        {
            string C = "Example";
            C = C.ToLower();
            //Console.WriteLine(c);
            string S = "John Doe; Peter Benjamin Parker; Mary Jane Watson-Parker; John Elvis Doe;" +
                "John Evan Doe; Jane Doe; Peter Brian Parker";
            string[] sarr = S.Split(';');
            string result = "";
            //List<string> emailchecking = new List<string>();
            Dictionary<string, int> emailchecking = new Dictionary<string, int>();
            for (int i = 0; i < sarr.Length; i++)
            {

                string name = sarr[i].Trim();
                string[] emp = sarr[i].Trim().Split(' ');
                string email = "";
                if (emp.Length == 3)
                {
                    if (!emailchecking.ContainsKey(emp[0]))
                    {
                        emailchecking.Add(emp[0], 1);
                    }
                    else
                    {
                        emailchecking[emp[0]] += 1;
                    }
                    email = generate3(emp[0], emp[1], emp[2], C, Convert.ToString(emailchecking[emp[0]]));

                }
                else
                {
                    if (!emailchecking.ContainsKey(emp[0]))
                    {
                        emailchecking.Add(emp[0], 1);
                    }
                    else
                    {
                        emailchecking[emp[0]] += 1;
                    }
                    email = generate2(emp[0], emp[1], C, Convert.ToString(emailchecking[emp[0]]));
                }
                result += name + " " + "<" + email + ">; ";
            }
            Console.WriteLine(result.Trim());
            Console.ReadLine();
        }
        static string generate2(string name, string lastn, string domain, string value)
        {
            string last = getlast(lastn);
            string result = "";
            if(Int32.Parse(value) == 1)
            {
                result = last.ToLower() + "_" + name.ToLower() + "@" + domain + ".com";
            }
            else
            {
                result = last.ToLower() + "_" + name.ToLower() + value + "@" + domain + ".com";
            }
            return result;
        }
        static string generate3(string name, string middle, string lastn, string domain, string value)
        {
            string last = getlast(lastn);
            string result = "";
            if (Int32.Parse(value) == 1)
            {
                result = last.ToLower() + "_" + name.ToLower() + "@" + domain + ".com";
            }
            else
            {
                result = last.ToLower() + "_" + name.ToLower() + value + "@" + domain + ".com";
            }
            return result;
        }
    static string getlast(string last)
    {
        char[] carr = last.ToCharArray();
        string result = "";
        for (int i = 0; i < carr.Length; i++)
        {
            if (char.IsLetter(carr[i]))
            {
                result += carr[i];
            }
        }
        return result;
    }
    static string newemail(string email)
    {
        string[] newe = email.Split('@');
        for (int i = 0; i < newe.Length; i++)
        {
            Console.Write("{0} : {1}", newe[0], newe[1]);
        }
        Console.WriteLine();
        return "";
    }
    }
}
