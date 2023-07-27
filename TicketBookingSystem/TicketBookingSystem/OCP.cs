/// <summary>
/// Open/Closed Principle (OCP)
/// </summary>
public abstract class PaymentProvider
{
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardPaymentProvider : PaymentProvider
{
    public override void ProcessPayment(decimal amount)
    {
        // Process credit card payment
        Console.WriteLine($"Credit card payment processed for amount {amount}");
    }
}

public class CashPaymentProvider : PaymentProvider
{
    public override void ProcessPayment(decimal amount)
    {
        // Accept cash payment
        Console.WriteLine($"Cash payment received for amount {amount}");
    }
}