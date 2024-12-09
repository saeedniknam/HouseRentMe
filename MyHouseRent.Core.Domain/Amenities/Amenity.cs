using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Shared;

namespace HouseRent.Core.Domain.Amenities;

public class Amenity : BaseEntity<int>
{
    private Amenity(int id, Title title, Description description, Money money) : base(id)
    {
        Title = title;
        Description = description;
        Money = money;

    }
    public Title Title { get; set; }
    public Description Description { get; set; }
    public Money Money { get; set; }

    public static Amenity Create(int id, Title title, Description description, Money price)
    {
        var amenity = new Amenity(id, title, description, price);
        amenity.AddDomainEvent(new AmenityCreated(id));
        return amenity;
    }

}
