using System;

namespace Classes_And_Object
{
    //to access private variable of class we use property
    class Mobile
    {
        public string MobileName { get; private set; }
        public string MobileModelName { get; set; }
        public int ISDN { get; private set; }

        public Mobile(string MobileName, /*string MobileModelName*/ int ISDN)
        {
            this.MobileName = MobileName;
            //this.MobileModelName = MobileModelName;
            this.ISDN = ISDN;
        }

        internal void DisplayDetails()
        {
            Console.WriteLine("Name :{0}\tISDN {1}", MobileName, ISDN);
        }

    }
    class MobileModel
    {
        Mobile mobile = new Mobile("Motorola",1234);
        
        internal void setModelNo()
        {
            mobile.MobileModelName = "G7Plus";
        }
        internal void DisplayModel()
        {
            Console.WriteLine("Model :{0}", mobile.MobileModelName);
        }
    }

    class PropertyEg
    {
        static void Main()
        {
            Mobile mobile = new Mobile("Motorola",12345);
            mobile.DisplayDetails();
            
            MobileModel mobileModel = new MobileModel();
            mobileModel.setModelNo();
            mobileModel.DisplayModel();
            Console.ReadKey();
        }
    }
}
