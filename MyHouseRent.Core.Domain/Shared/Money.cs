namespace HouseRent.Core.Domain.Shared;

public record Money(decimal Amount)
{
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }
    public bool IsZero() => Amount == 0;
}