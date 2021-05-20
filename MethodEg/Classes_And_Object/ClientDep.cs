using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Object
{
    class ClientDep
    {
        static void Main() {
            new Department();
            //Department Dep2 = new Department("LTI");
            //Single department
            Department Dep3 = new Department(1, "HR", "Chennai");

            //Dep2.orgname();
            Dep3.details();

            //For Multiple 

      
            Console.WriteLine("-----------------User input-------------");
            Console.WriteLine("Enter organizaiton name : ");
            Department.Orgname = Console.ReadLine();
            Console.WriteLine("Enter number of depts :");
            int size = Convert.ToInt32(Console.ReadLine());
            Department[] DeptArr = new Department[size];
            /*
             * DeptArr[0] = new Department(2, "Sales", "Pune");
             * DeptArr[1] = new Department(3, "Marketing", "Delhi");
             * DeptArr[2] = new Department(4, "Finance", "Mumbai");
            */

            for(int i=0; i<DeptArr.Length; i++)
            {
                Console.WriteLine("Enter the ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Location :");
                string location = Console.ReadLine();
                DeptArr[i] = new Department(id, Name, location);
            }

            foreach(Department d in DeptArr)
            {
                d.details();
            }




            Console.Read();
        }

        
    }
}
