namespace HouseRent.Core.Domain.Homes
{
    public record HomeCreatedDomainEvent(int id) : IDomainEvent;
}