using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Bookings
{
    public record DateRange(DateOnly start, DateOnly end)
    {
        public static DateRange Create(DateOnly start, DateOnly end)
        {
            if (start > end)
            {
                throw new DomainException("تاریخ انتها از ابتدا کوچکتر است");
            }
            return new DateRange(start, end);
        }

        public int LenghtDays => end.DayNumber - start.DayNumber;
    }


}