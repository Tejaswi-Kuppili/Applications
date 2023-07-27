using System;

public class Program
{
    public static void Main()
    {
        IShowFinder showFinder = new ShowFinder();
        ISeatManager seatManager = new SeatManager();
        IEmailService emailService = new EmailService();

        TicketBookingSystem ticketBookingSystem = new TicketBookingSystem(showFinder, seatManager, emailService);

        ticketBookingSystem.BookTicket("#12", "sandeep@gmail.com");
        ticketBookingSystem.BookTicket("#12", "krishna@gmail.com");
        ticketBookingSystem.BookTicket("#12", "manohar@gmail.com");
    }
}