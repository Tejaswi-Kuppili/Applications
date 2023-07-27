/// <summary>
/// Liskov Substitution Principle (LSP)
/// </summary>
public interface ITicket
{
    string GenerateTicket();
}

public class RegularTicket : ITicket
{
    public string GenerateTicket()
    {
        return "Regular ticket generated.";
    }
}

public class VipTicket : ITicket
{
    public string GenerateTicket()
    {
        return "VIP ticket generated.";
    }
}