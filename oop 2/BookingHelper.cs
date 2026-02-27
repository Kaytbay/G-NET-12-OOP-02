using System;

public static class BookingHelper
{

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double totalPrice = numberOfTickets * pricePerTicket;

        if (numberOfTickets >= 5)
        {
            
            totalPrice -= totalPrice * 0.1;

        }

        return totalPrice;
    }

    private static int counter = 0;
    public static string GenerateBookingReference()
    {
        counter++;

        return $"BK-{counter}";
    }
}



