using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Shared;

namespace HouseRent.Core.Domain.Bookings;

public class Booking : BaseEntity<int>
{
    private Booking(int id,
        int homeId,
        int userId,
        DateRange dateRange,
        Money bookingMoney,
        Money sumAmenitiesMoney,
        DateTime createdDate,
        BookingStatus bookingStatus) : base(id)
    {
        HomeId = homeId;
        UserId = userId;
        DateRange = dateRange;
        BookingMoney = bookingMoney;
        SumAmenitiesMoney = sumAmenitiesMoney;
        CreatedDate = createdDate;
        BookingStatus = bookingStatus;
    }

    public int HomeId { get; set; }
    public int UserId { get; set; }
    public DateRange DateRange { get; }
    public Money BookingMoney { get; }
    public Money SumAmenitiesMoney { get; }
    public DateTime CreatedDate { get; }
    public BookingStatus BookingStatus { get; }

    public static Booking Create(int id,
        int homeId,
        int userId,
        DateRange dateRange,
        Money bookingMoney,
        Money sumAmenitiesMoney,
        DateTime createdDate,
        BookingStatus bookingStatus)
    {
        Booking booking = new(id, homeId, userId, dateRange, bookingMoney, sumAmenitiesMoney, createdDate, bookingStatus);
        booking.AddDomainEvent(new CreateBookingDomainEvent(id));
        return booking;
    }
}
