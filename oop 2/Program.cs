using oop_1;
using System.Security.Cryptography.X509Certificates;

namespace oop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1:

            #region Q01:

            /*public class BankAccount
           {
            public string Owner;
            public double Balance;

            public void Withdraw(double amount)
            {
                Balance -= amount;
           }
              }
               */




            // a) Identify at least two problems with this design from an encapsulation perspective.
            // 1 the fields are public 
            // 2 there is no validation 





            // b) Describe how you would fix this class to follow proper encapsulation principles. You do not need to write the full code.
            // make private fields and use methods to access and modify
            // add validation in the methods 




            //c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.
            // because i cann access the fields without control or validation which make invalid thingss ;



            #endregion


            #region Q02:

            /*
              Q02 : What is the difference between a field and a property in C#? Can a property contain logic? 
              Give an example of a read-only property that returns a calculated value.
             */

            //1 fields is a variable i can access it directly no validation and  no control and it can be public or private 
            //2.  property is a private field with get and set method to access it and validation 
            //  and there is a automatic property ;


            // yes a property can contain logic in the get and set method


            //ex 

            /*
             
                Public int count => _count*10;

                public int area
                {
                    get
                    {
                        return w * l;
                    }
                }
            
             */



            #endregion


            #region Q03:

            /*
             public class StudentRegister
            {
                private string[] names = new string[5];

                public string this[int index]
                {
                    get { return names[index]; }
                    set { names[index] = value; }
                }
            }
             */

            //a) What is `this[int index]` called? Explain its purpose
            // called indexer it use to access the object like a collection like array ;




            //b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
            // this is exeption out o the range of the array




            //c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
            // yes and itis called indexer overloading  
            // useful when i have collection like books and i want to access it by isbn or by id  (string or int )
            #endregion


            #region Q04:

            /*
             public class Order
            {
                public static int TotalOrders = 0;
                public string Item;
 
                public Order(string item)
                {
                    Item = item;
                    TotalOrders++;
                }
            }
             
             */


            //  a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?

            // static totalorders belong to the type itsels the class
            // item belong to the object




            //b) Can a static method inside `Order` access the `Item` field directly? Why or why not?

            // no because the item is belong to a specific object and the static donot know what is the object exactly ;

            #endregion


            #endregion




            #region Part2:


            Console.WriteLine(" Ticket Booking ==========\n");         
            Cinema myCinema = new Cinema();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Data Ticket {i+1}:");

                Console.Write("Movie Name:");
                string? movieName = Console.ReadLine();

                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Seat Row  ");
                char seatRow = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Seat Number: ");
                int seatNumber = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

              
                SeatPosition seat = new SeatPosition { Row = seatRow, Numper = seatNumber };

                Ticket newTicket = new Ticket(movieName, type, seat, price);

                myCinema.AddTicket(newTicket);
            }







            Console.WriteLine("All Tickets ==========\n");
            for (int i = 0; i < 3; i++)
            {
                Ticket t = myCinema[i];

                Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat.Row}-{t.Seat.Numper} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP");

            }
          







            Console.WriteLine(" Search by Movie ==========");
            Console.Write("Enter movie name to search: ");
            string moviename = Console.ReadLine();

            Ticket t1 = myCinema[moviename];

            if (t1 != null)
            {
                Console.WriteLine($"Found: Ticket #{t1.TicketId} | {t1.MovieName} | {t1.Type} | Seat: {t1.Seat.Row}-{t1.Seat.Numper} | Price: {t1.Price} EGP\n");
            }
            else Console.WriteLine("Movie not found.\n");
            

            Console.WriteLine("System Stats ==========");
            Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");



            Console.WriteLine($"Booking Ref 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Ref 2: {BookingHelper.GenerateBookingReference()}");

            double discountedTotal = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"Group Discount : {discountedTotal}");


            #endregion




        }
    }
}
