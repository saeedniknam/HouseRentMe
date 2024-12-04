namespace HouseRent.Core.Domain.Bookings.Contract;

public interface IReservationRead
{
    Task<List<Booking>> BookingListAsync();
}
