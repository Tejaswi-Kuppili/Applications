/// <summary>
/// Dependency Inversion Principle (DIP)
/// </summary>
public class ShowFinder : IShowFinder
{
    public Show GetShow(string showId)
    {
        // Retrieve show details from database or external API
        return new Show { ShowId = showId, Title = "Benefit Show", Date = DateTime.Now };
    }
}

public class SeatManager : ISeatManager
{
    private List<Seat> availableSeats;

    public SeatManager()
    {
        // Initialize available seats from database or external API
        availableSeats = new List<Seat>
        {
            new Seat { SeatNumber = "A1", ShowId = "#12" },
            new Seat { SeatNumber = "B2", ShowId = "#12" },
            new Seat { SeatNumber = "C3", ShowId = "#12" }
        };
    }

    public Seat FindAvailableSeat(Show show)
    {
        // Find an available seat for the given show
        return availableSeats.FirstOrDefault(s => s.ShowId == show.ShowId);
    }

    public void BookSeat(Seat seat)
    {
        // Update seat status to booked in the database or external API
        availableSeats.Remove(seat);
    }
}

public class EmailService : IEmailService
{
    public void SendConfirmationEmail(Show show, Seat seat, string customerEmail)
    {
        // Send confirmation email to the customer
        Console.WriteLine($"Confirmation email sent to {customerEmail} for show {show.Title} and seat {seat.SeatNumber}");
    }
}
