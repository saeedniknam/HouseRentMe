using HouseRent.Core.Domain.Bookings.Contract;

namespace HouseRent.ApplicationService.Booking.Queries;

internal class ReservationRead : IReservationRead
{
    public Task<List<Booking>> BookingListAsync()
    {
        throw new NotImplementedException();
    }
}
