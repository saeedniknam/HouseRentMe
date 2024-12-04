using HouseRent.Core.Domain.Bookings;
using HouseRent.Core.Domain.Bookings.Contract;

namespace HouseRent.ApplicationService.Read.BookingRead;

internal class ReservationRead : IReservationRead
{
    public Task<List<Booking>> BookingListAsync()
    {
        throw new NotImplementedException();
    }
}
