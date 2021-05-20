using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Day7TransactionScope
{
    class Program
    {
        static void LocalTransaction()
        {
            string datainfo = "Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; Initial Catalog = Northwind; User ID = sa; Password = newuser123#";
            using (TransactionScope myscope = new TransactionScope())
            {
                using (var conn = new SqlConnection(datainfo))
                {
                    conn.Open();
                    try
                    {
                        var cmd1 = new SqlCommand("insert into region values (12,'sw')", conn);
                        int i = cmd1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("Inserted into region ");
                        }
                        else
                        {
                            Console.WriteLine("Not inserted");
                        }
                        var cmd2 = new SqlCommand("insert into shippers values ('Amazon','(505)55-9834')",conn);
                        int j = cmd2.ExecuteNonQuery();
                        if (j > 0)
                        {
                            Console.WriteLine("Inserted into shippers");
                        }
                        else
                        {
                            Console.WriteLine("Not inserted");
                        }
                        myscope.Complete();

                    }catch(SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        static void DistributedTransaction()
        {
            string str1 = "Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; Initial Catalog = Northwind; User ID = sa; Password = newuser123#";
            string str2 = "Data Source = DESKTOP-UJF6A2L\\SQLEXPRESS; Initial Catalog = dbemployee_864; User ID = sa; Password = newuser123#";
            using (TransactionScope myscope = new TransactionScope())
            {
                using (var conn = new SqlConnection(str1))
                {
                    conn.Open();
                    var cmd1 = new SqlCommand("insert into shippers values ('Dream11','(505)55-9834')", conn);
                    int x = cmd1.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Console.WriteLine("Inserted into shippers");
                    }
                    else
                    {
                        Console.WriteLine("Filed !!!");
                    }
                    using (var conn1 = new SqlConnection(str2))
                    {
                        conn1.Open();
                        var cmd2 = new SqlCommand("insert into tbldepartment values('Digital Tech','Mumbai')", conn1);
                        int y = cmd2.ExecuteNonQuery();
                        if (y > 0)
                        {
                            Console.WriteLine("Inserted into department");
                        }
                        else
                        {
                            Console.WriteLine("Filed !!!");
                        }

                    }
                    myscope.Complete();
                }
            }
        }
        static void Main()
        {
            //LocalTransaction();
            DistributedTransaction();
            Console.ReadLine();
        }
    } 
}
