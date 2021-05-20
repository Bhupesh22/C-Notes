using System;


namespace Inheritance
{
    class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string BankName = "SBI";
        public person(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            Console.WriteLine("Base Class Person Constructor\n");
        }

        protected void Display()
        {
            Console.WriteLine("Name :{0} ", Name);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Gender:{0}", Gender);
        }

        internal protected void DisplayAge()
        {
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Gender:{0}", Gender);
        }
        ~person()
        {
            Console.WriteLine("Destructor for Person");
        }
    }
    class Employee : person
    {
        public int Eid { get; set; }
        public int SalaryPerHr { get; set; }

        public string BankName = "HDFC";
        public Employee(string Name, int Age, string Gender, int Eid, int SalaryPerHr): base(Name, Age, Gender)
        {
            this.Eid = Eid;
            this.SalaryPerHr = SalaryPerHr;
            Console.WriteLine("Derived class Employee Constructor\n");
        }

        internal void DisplayEmp()
        {
            Display();          //since it is internal / public it will be accessible , not private
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Eid :{0}", Eid);
            Console.WriteLine("Salary:{0}", SalaryPerHr);
            Console.WriteLine("Person Bank :{0}", base.BankName); //if base is not used then only hdfc is result
            Console.WriteLine("Employee Bank:{0}", BankName);
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for employee");
        }
    }
    class FullTimeEmployee : Employee
    {
        int WorkingHours { get; set; }
        int TotalSalary;
        public FullTimeEmployee(string Name, int Age, string Gender, int Eid, int SalaryPerHr,int WorkingHours) : base(Name, Age, Gender, Eid, SalaryPerHr)
        {
            this.WorkingHours = WorkingHours;
            Console.WriteLine("Derived class Full Time Employee Constructor\n");
        }
        internal void CalSalary()
        {
            TotalSalary = SalaryPerHr * WorkingHours;
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Eid :{0}", Eid);
            Console.WriteLine("Salary per Hr:{0}", SalaryPerHr);
            //Console.WriteLine("Person Bank :{0}", base.BankName); //if base is not used then only hdfc is result
            //Console.WriteLine("Employee Bank:{0}", BankName);
            Console.WriteLine("Working Hours:{0} ", WorkingHours);
            Console.WriteLine("Total Salary :{0} ", TotalSalary);
        }
        ~FullTimeEmployee()
        {
            Console.WriteLine("Destructor for full time employee");
        }
    } 

    class PartTimeEmployee : Employee
    {
        int WorkingHoursPart { get; set; }
        int TotalPartSalary { get; set; }

        internal PartTimeEmployee(string Name, int Age, string Gender, int Eid, int SalaryPerHr, int WorkingHoursPart) :base(Name, Age, Gender, Eid, SalaryPerHr)
        {
            this.WorkingHoursPart = WorkingHoursPart;
            Console.WriteLine("Derived class Part Time Employee Constructor\n");
        }

        internal void CalSalary()
        {
            TotalPartSalary = SalaryPerHr * WorkingHoursPart;
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Eid :{0}", Eid);
            Console.WriteLine("Salary per Hr:{0}", SalaryPerHr);
            //Console.WriteLine("Person Bank :{0}", base.BankName); //if base is not used then only hdfc is result
            //Console.WriteLine("Employee Bank:{0}", BankName);
            Console.WriteLine("Working Hours:{0} ", WorkingHoursPart);
            Console.WriteLine("Total Salary :{0} ", TotalPartSalary);
        }

        ~PartTimeEmployee()
        {
            Console.WriteLine("Destructor for part time employee");
        }
    }

    class InheritancePerson
    {
        static void Main()
        {
            //Employee Emp = new Employee("Bhupesh",22,"Male",1001,30000);
            //Emp.DisplayEmp();

            FullTimeEmployee FTE = new FullTimeEmployee("Bhupesh", 22, "Male", 1001, 3400, 95);
            FTE.CalSalary();

            PartTimeEmployee PTE = new PartTimeEmployee("Akshay", 23, "Male", 1002, 3700, 67);
            PTE.CalSalary();
            GC.Collect();
            Console.ReadLine();
        }
    }
}
