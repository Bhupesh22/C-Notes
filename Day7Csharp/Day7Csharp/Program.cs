using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Day7Csharp
{
    class tblDepartment
    {
        public int did { get; set; }
        public string dname { get; set; }
        public string location { get; set; }

        internal void getDepartment()
        {
            Console.WriteLine("Enter Department ID :");
            did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            dname = Console.ReadLine();
            Console.WriteLine("Enter location");
            location = Console.ReadLine();
        }
    }
    class DataAccess
    {
        SqlConnection conn = null;
        SqlCommand cmd;

        public SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; " +
                "Initial Catalog = dbemployee_864; User ID = sa; Password = newuser123#");
            conn.Open();
            return conn;
        }

        public void DisplayDept()
        {
            try
            {
                conn = getConnection();
                SqlDataReader sdr;
                cmd = new SqlCommand("select * from tblDepartment",conn);
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
            finally
            {
                conn.Close();
            }
        }
        internal void InvokeScalar()
        {
            conn = getConnection();
            cmd = new SqlCommand("select count(did) from tblDepartment",conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No. of Departments : {0}", count);
        }
        internal void StoredProcedureCall()
        {
            conn = getConnection();
            Console.WriteLine("Enter Employee ID:");
            int empid = Convert.ToInt32(Console.ReadLine());
            
            cmd = new SqlCommand("dbo.proc_taxcal", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            /*
            SqlParameter sqlparam = new SqlParameter("@did", did);
            sqlparam.Direction = ParameterDirection.Input;
            sqlparam.DbType = DbType.Int32;

            SqlParameter outparam = new SqlParameter("@res", result);
            sqlparam.Direction = ParameterDirection.Output;
            sqlparam.DbType = DbType.String;

            cmd.Parameters.Add(sqlparam);
            cmd.Parameters.Add(outparam);
            */
            cmd.Parameters.AddWithValue("@empid", empid);

            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Department is : {0}", sdr);
            while (sdr.Read())
            {
                Console.WriteLine("Tax is : {0}", sdr[0]);
            }
            conn.Close();


        }
        internal void StoredProcedureOutput()
        {
            try
            {

                conn = getConnection();
                Console.WriteLine("Enter department id :");
                int did = Convert.ToInt32(Console.ReadLine());

                string res = "";
                cmd = new SqlCommand("dbo.depart_name", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter input = new SqlParameter("@did", did);
                input.Direction = ParameterDirection.Input;
                input.DbType = DbType.Int32;
                
                SqlParameter output = new SqlParameter("@res", res);
                output.Direction = ParameterDirection.Output;
                output.DbType = DbType.String;

                cmd.Parameters.Add(input);
                //cmd.Parameters.Add("@res", SqlDbType.VarChar,20);
                //cmd.Parameters["@res"].Value = res;
                cmd.Parameters.Add(output);
                //SqlDataReader sdr;
                //sdr = cmd.ExecuteReader();
                string temp = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine(temp);
                //sdr = cmd.ExecuteReader();
                /*while (sdr.Read())
                {
                    Console.WriteLine("DEPTNAME :{0} ", sdr[0]);
                }*/
               

            }catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess dac = new DataAccess();
            try
            {
                //dac.InvokeScalar();
                //dac.DisplayDept();
                //dac.StoredProcedureCall();
                dac.StoredProcedureOutput();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
