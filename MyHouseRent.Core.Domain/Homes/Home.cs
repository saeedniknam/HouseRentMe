using HouseRent.Core.Domain.Bookings;
using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Shared;

namespace HouseRent.Core.Domain.Homes;

public class Home : BaseEntity<int>
{
    private Home(int id,
        int userId,
        Title title,
        Description description,
        Address address,
        List<int> amenities) : base(id)
    {
        UserId = userId;
        Title = title;
        Description = description;
        Address = address;
        Amenities = amenities;
    }

    public int UserId { get; set; }
    public Title Title { get; set; }
    public Description Description { get; set; }
    public Address Address { get; set; }
    public List<int> Amenities { get; set; }
    public Money Price { get; set; }
    public DateTime? LastReservationDate { get; private set; }

    public static Home Create(int id,
        int userId,
        Title title,
        Description description,
        Address address,
        List<int> amenities)
    {
        Home home = new Home(id, userId, title, description, address, amenities);
        home.AddDomainEvent(new HomeCreated(id));
        return home;
    }
    public static Result Reserve(DateTime reservedDate)
    {
        return new Result();
        ///////////////
    }
}
