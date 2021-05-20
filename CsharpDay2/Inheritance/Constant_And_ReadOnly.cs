using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ConstExample
    {
        public const float pi = 3.14f;
        
        //Adding constant to constant is allowed but otherwise no changes are allowed
        const int x = 5; 
        const int y = x + 5;

        //eg. This will give error.
        //int f = 5;
        //const int g = f + 5;  


        //changing const is not allowed 
        //cannot add any other value to const 
        public void PerimeterOfCirlce(int Radius)
        {
            Console.WriteLine("Perimeter of circle : {0}", 2 * pi * Radius);
        }
    }

    class ReadOnly
    {
        internal readonly string SchoolName;
        internal readonly string OrgName = "L&T";

        //Read only can be changed at runtime
        internal ReadOnly(string SchoolName, string OrgName)
        {
            this.SchoolName = SchoolName;
            this.OrgName = OrgName;
        }
        /*void DisplayStudent()
        {
            SchoolName = "MN"; // CANNOT BE ASSIGNED (Only while declareing or constructor)
        }*/
        internal void DisplayOrg()
        {
            Console.WriteLine("Organization name :{0} ", OrgName);
        }
    }
    class Constant_And_ReadOnly
    {
        
        static void Main()
        {
            ConstExample constExample = new ConstExample();
            constExample.PerimeterOfCirlce(100);

            //OrgName will be changed at runtime
            ReadOnly readOnly = new ReadOnly("DAV", "TCS");
            readOnly.DisplayOrg();

            ReadOnly readOnly1 = new ReadOnly("Fatima", "Wipro");
            readOnly1.DisplayOrg();
            Console.ReadLine();
        }
    }
}
