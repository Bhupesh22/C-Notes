using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Object
{
    class Department
    {
        int Did;
        string Dname, Location;
        //static string Orgname = "LTI";
        internal static string Orgname; //this will give error in other use classname.orgname
        internal Department()
        {
            Console.WriteLine("Default constructor");
        }
        /*internal Department(string Orgname)
        {
            this.Orgname = Orgname;
        }*/

        internal Department(int id, string name, string Location)
        {
            Did = id;
            Dname = name;
            this.Location = Location;
        }
        internal void details()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Output Details-----------------");
            Console.WriteLine("Id : {0}", Did);
            Console.WriteLine("Name: {0}", Dname);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Organization: {0}", Orgname);
        }
        
    }
    class ConstructorEx
    {
        /*static void Main()
        {
            new Department();
            Department Dep2 = new Department("LTI");
            Department Dep3 = new Department(1, "HR", "Chennai");

            Dep2.orgname();
            Dep3.details();
            Console.Read();
        }*/
    }
}