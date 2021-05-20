using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOProgExample
{
    class Program
    {
        public static SqlConnection conn = new SqlConnection(); //connection object
        public static SqlCommand cmd = new SqlCommand(); //Command object
        public static SqlDataReader sdr;
        static void Main(string[] args)
        {
            InsertData();
            Console.WriteLine("\n-------------------------------\n");
            SelectData();
            Console.Read();
        }
        public static void InsertData()
        {
            try
            {
                conn = getConnection();
                /*cmd = new SqlCommand("Insert into Shippers values('FedEx','(503)555-1024')", conn);
                int s = cmd.ExecuteNonQuery();
                if (s > 0)
                {
                    Console.WriteLine("Successfully Inserted");
                }
                else
                {
                    Console.WriteLine("Falied to Insert");
                }*/

                //Dynamic
                Console.WriteLine("Enter Shipper Name & Phone Number");
                string shipname = Console.ReadLine();
                string phone = Console.ReadLine();

                cmd = new SqlCommand("Insert into Shippers values(@shipname, @phone)", conn);
                
                cmd.Parameters.AddWithValue("@shipname",shipname);  //Binding 
                cmd.Parameters.AddWithValue("@phone", phone);       //Binding

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
                cmd = new SqlCommand("select * from Shippers", conn);
                //cmd = new SqlCommand("select * from Employees");
                //cmd.Connection(conn);
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
            
            
        } 
        static SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; " +
                "Initial Catalog = NorthWind; User ID = sa; Password = newuser123#");
            conn.Open();
            return conn;
        }
    }
}
