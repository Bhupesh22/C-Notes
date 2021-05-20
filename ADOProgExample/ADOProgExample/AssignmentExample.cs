using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data;

namespace ADOProgExample
{
    class AssignmentExample
    {
        public static SqlConnection conn = new SqlConnection(); //connection object
        public static SqlCommand cmd = new SqlCommand(); //Command object
        public static SqlDataReader sdr;
        static void Main()
        {
            //InsertData();
            //DeleteData();
            //SelectData();
            ProcedureCall();
            UpdateData();
            Console.Read();
        }
        public static void UpdateData()
        {
            try
            {
                conn = getConnection();
                Console.WriteLine("Enter empid who you want to increment salary : ");
                int empid = Convert.ToInt32(Console.ReadLine());

                SqlCommand check = new SqlCommand("Select * from tblEmployee where empid = @empid", conn);
                check.Parameters.AddWithValue("@empid", empid);
                sdr = check.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine("Do you want to update salary of ... ?");
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write("{0} ", sdr[i]);
                    }
                }
                sdr.Close();
                Console.WriteLine();
                Console.WriteLine("Confirm (Y/N) ??");
                string ans = Console.ReadLine();
                if (ans.ToUpper() == "Y")
                {
                    try
                    {
                        cmd = new SqlCommand("Update tblEmployee set salary = salary * 1.25 where empid = @empid", conn);
                        cmd.Parameters.AddWithValue("@empid", empid);
                        int z = cmd.ExecuteNonQuery();
                        if (z > 0)
                        {
                            Console.WriteLine("Updated salary for given employee");
                        }
                        else
                        {
                            Console.WriteLine("Could not update");
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Not found !!!");
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }       
        public static void ProcedureCall()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("dbo.proc_callemp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine($"{sdr[0]}\t{sdr[1]}\t{sdr[2]}"); 
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
        }
        public static void InsertData()
        {
            try
            {
                conn = getConnection();

                Console.WriteLine("Enter empid :");
                int empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ename : ");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter hiredate : ");
                string hiredate = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter Department ID : ");
                int did = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Gender : ");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter Manager ID : ");
                int mgrid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("Insert into tblEmployee values(@empid, @ename, @hiredate, @salary, @city, @did, @gender, @mgrid, @age)", conn);

                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@hiredate", hiredate);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@did", did);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@mgrid", mgrid);
                cmd.Parameters.AddWithValue("@age", age);

                int s = cmd.ExecuteNonQuery();
                if (s > 0)
                {
                    Console.WriteLine("Successfully Inserted");
                }
                else
                {
                    Console.WriteLine("Falied to Insert");
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void DeleteData()
        {
            try
            {
                conn = getConnection();
                Console.WriteLine("Enter empid you want to delete : ");
                int empid = Convert.ToInt32(Console.ReadLine());
                SqlCommand check = new SqlCommand("Select * from tblEmployee where empid = @empid", conn);
                check.Parameters.AddWithValue("@empid", empid);
                sdr = check.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine("Do you want to delete ... ?");
                    for(int i=0;i<sdr.FieldCount; i++)
                    {
                        Console.Write("{0} ", sdr[i]);
                    }
                }
                sdr.Close();
                Console.WriteLine();
                Console.WriteLine("Confirm (Y/N) ??");
                string ans = Console.ReadLine();
                if(ans.ToUpper() == "Y")
                {
                    cmd = new SqlCommand("delete from tblEmployee where empid = @empid", conn);
                    cmd.Parameters.AddWithValue("@empid", empid);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        Console.WriteLine("Deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Delete operation unsuccessful !!");
                    }
                }
                else
                {
                    Console.WriteLine("Okay ... No Deletion occured");
                }
                
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private static void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("select * from tblEmployee", conn);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine($"{sdr[0]}\t{sdr[1]}\t{sdr[2]}");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }


        }
        static SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; " +
                "Initial Catalog = dbemployee_864; User ID = sa; Password = newuser123#");
            conn.Open();
            return conn;
        }
    }
}
