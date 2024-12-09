namespace HouseRent.Core.Domain.Framework;

internal class DomainException : Exception
{
    public DomainException(string? message) : base(message)
    {
    }
}
