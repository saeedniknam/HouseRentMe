namespace HouseRent.Core.Domain.Framework;

public record Error(string Code, string Name)
{
    public static Error Nothing = new(string.Empty, string.Empty);
    public static Error NullValue = new("Null Error","Error is Null");
}