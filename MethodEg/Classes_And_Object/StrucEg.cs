using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Object
{
    // Structure is User Defined - Value type help to hold variable of different data type
    class StrucEg
    {
        public struct Pen
        {
            
            public string PenName { get; set; }
            public string PenColor { get; private set; }
            
            public Pen(string PenName, string PenColor)
            {
                this.PenName = PenName;
                this.PenColor = PenColor;
            }
            


        }
        static void Main()
        {
            Pen p = new Pen("Reynolds","Blue");
            
            //this will be the new value of the pen name set via struc
            p.PenName = "Racer";
            //p.PenColor = "Black";
            Console.WriteLine("Pen Name:{0} and Pen Color :{1}", p.PenName, p.PenColor);
            Console.ReadLine();
        }
    }
}
