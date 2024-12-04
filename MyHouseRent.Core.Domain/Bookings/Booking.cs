using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Bookings;

public class Booking : BaseEntity<int>
{
    private Booking(int id,
        int homeId,
        int userId,
        DateRange dateRange,
        bool status) : base(id)
    {
        HomeId = homeId;
        UserId = userId;
        DateRange = dateRange;
        Status = status;
    }

    public int HomeId { get; set; }
    public int UserId { get; set; }
    public DateRange DateRange { get; set; }
    public bool Status { get; set; }
    public static Booking Create(int id,
        int homeId,
        int userId,
        DateRange dateRange,
        bool status)
    {
        Booking booking = new(id, homeId, userId, dateRange, status);
        booking.AddDomainEvent(new CreateBookingDomainEvent(id));
        return booking;
    }
}
