using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Day7DisconnectedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string datainfo = "Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; Initial Catalog = Northwind; User ID = sa; Password = newuser123#";

            SqlConnection conn = null;
            SqlCommand cmd;
            SqlDataAdapter sda;
            
            try
            {
                conn = new SqlConnection(datainfo);
                conn.Open();
                sda = new SqlDataAdapter("select * from Region", conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "NorthwindRegion");
                DataTable dt = ds.Tables["NorthwindRegion"];
                foreach(DataRow row1 in dt.Rows)
                {
                    foreach(DataColumn col1 in dt.Columns)
                    {
                        Console.Write($"{row1[col1]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("--------------------------------------------");
                /*
                sda = new SqlDataAdapter("select * from Shippers", conn);
                //ds = new DataSet();
                sda.Fill(ds, "NorthwindShippers");
                dt = ds.Tables["NorthwindShippers"];
                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write($"{row1[col1]} ");
                    }
                    Console.WriteLine();
                }
                */
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                
                sda.Fill(ds);
                //Inserting into datatable of dataset
                
                DataRow r = ds.Tables["NorthwindRegion"].NewRow();
                r["RegionID"] = 10;
                r["RegionDescription"] = "Northwest";

                //add new row
                ds.Tables["NorthWindRegion"].Rows.Add(r);
                sda.UpdateCommand = scb.GetUpdateCommand();
                int res = sda.Update(ds.Tables[0]); //comment shippers part then it will update in og table
                Console.WriteLine("{0} ", res);
                Console.WriteLine("----------------------------------------------");
                
                dt = ds.Tables["NorthwindRegion"];
                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write($"{row1[col1]} ");
                    }
                    Console.WriteLine();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
            Console.ReadLine();
        }
    }
}
