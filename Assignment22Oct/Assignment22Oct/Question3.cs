using System;


namespace Assignment22Oct
{
    public class TicketBookingException : ApplicationException
    {
        public TicketBookingException(string Message) : base(Message)
        {

        }
    }
    class Passenger
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfTicket { get; set; }

        public Passenger(string Name, int Age, int NumberOfTicket)
        {
            this.Name = Name;
            this.Age = Age;
            this.NumberOfTicket = NumberOfTicket;
        }
        
        public void TicketBooking(int NumberOfTicket)
        {
            try
            {
                if (NumberOfTicket > 2)
                {
                    throw new TicketBookingException("Cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("Ticket Book Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
    class Question3
    {
        static void Main()
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of tickets :");
            int not = Convert.ToInt32(Console.ReadLine());
            Passenger p = new Passenger(name, age, not);
            p.TicketBooking(not);
            Console.ReadLine();
        }
    }
}
