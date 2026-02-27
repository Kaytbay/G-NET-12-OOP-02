using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{

    enum TicketType
    {
        Standard,
        VIP,
        IMax
    }

    struct SeatPosition
    {
        public char Row { get; set; }
        public int Numper { get; set; }

        public override string ToString()
        {
            return $"{Row}{Numper}";
        }

        internal static SeatPosition Defaultseat()
        {
            SeatPosition defaultSeat = new SeatPosition { Row = 'A', Numper = 1 };
            return defaultSeat;
        }

    }   
    internal class Ticket
    {


        private double _price;
        private string _movieName;
        private static int _ticketCounter;

        public int TicketId { get; private set; }
        public string MovieName
        {
            get { return _movieName; }
            set {
             if (!string.IsNullOrWhiteSpace(value))
                {
                  _movieName = value; 
                }
            }
        }
        public TicketType Type { get; set; }
        public SeatPosition Seat { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0) _price = value;
            }
        }
        public double PriceAfterTax
        {
            get { return Price + (Price * 0.14); }
        }


        public Ticket(string name , TicketType type, SeatPosition seat, double price)
        {
            MovieName = name;
            Type = type;
            Seat = seat;
            Price = price;

            _ticketCounter++;
            TicketId = _ticketCounter;
        }
        public Ticket (string name) : this(name, TicketType.Standard,SeatPosition.Defaultseat(), 50)
        {

        }

        public static int GetTotalTicketsSold()
        {
            return _ticketCounter;
        }

        //public double CalcTotal(double taxPercent)
        //{
        //    return (Price + Price * taxPercent);
        //}

        //public void ApplyDiscount(ref double discountAmount)
        //{
        //    if (discountAmount > 0 && discountAmount <= Price)
        //    {
        //        Price -= discountAmount;
        //        discountAmount = 0; 
        //    }
        //}

        //public void PrintTicket()
        //{
        // Console.WriteLine($" Movie : {MovieName} , Type  : {Type}  , Seat  : {Seat}  , Price : {Price}  Total (14% tax): {CalcTotal(0.14)}" );
        //}
    }
}
