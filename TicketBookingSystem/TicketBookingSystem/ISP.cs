/// <summary>
/// Interface Segregation Principle (ISP)
/// </summary>
public interface IBookingConfirmation
{
    void SendConfirmation(string customerEmail);
}

public class EmailConfirmation : IBookingConfirmation
{
    public void SendConfirmation(string customerEmail)
    {
        Console.WriteLine($"Email confirmation sent to {customerEmail}");
    }
}

public class SmsConfirmation : IBookingConfirmation
{
    public void SendConfirmation(string customerEmail)
    {
        Console.WriteLine($"SMS confirmation sent to {customerEmail}");
    }
}