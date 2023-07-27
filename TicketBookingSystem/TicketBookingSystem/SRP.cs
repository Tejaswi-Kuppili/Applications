using System;

public class TicketBookingSystem
{
    /// <summary>
    /// Single Responsibility Principle (SRP)
    /// </summary>
    private readonly IShowFinder showFinder;
    private readonly ISeatManager seatManager;
    private readonly IEmailService emailService;

    public TicketBookingSystem(IShowFinder showFinder, ISeatManager seatManager, IEmailService emailService)
    {
        this.showFinder = showFinder;
        this.seatManager = seatManager;
        this.emailService = emailService;
    }

    public void BookTicket(string showId, string customerEmail)
    {
        Show show = showFinder.GetShow(showId);

        if (show != null)
        {
            Seat seat = seatManager.FindAvailableSeat(show);

            if (seat != null)
            {
                seatManager.BookSeat(seat);
                emailService.SendConfirmationEmail(show, seat, customerEmail);
                Console.WriteLine("Ticket booked successfully.");
            }
            else
            {
                Console.WriteLine("No available seats for the selected show.");
            }
        }
        else
        {
            Console.WriteLine("Invalid show ID.");
        }
    }
}

public class Show
{
    public string ShowId { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
}

public class Seat
{
    public string SeatNumber { get; set; }
    public string ShowId { get; set; }
}

public interface IShowFinder
{
    Show GetShow(string showId);
}

public interface ISeatManager
{
    Seat FindAvailableSeat(Show show);
    void BookSeat(Seat seat);
}

public interface IEmailService
{
    void SendConfirmationEmail(Show show, Seat seat, string customerEmail);
}