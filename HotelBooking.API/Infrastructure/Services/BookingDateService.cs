using HotelBooking.API.Domain.Entities;

namespace HotelBooking.API.Infrastructure.Services;

public class BookingDateService : IBookingDateService
{
    private const int BookingDaysAhead = 330;

    public BookingDateRange GetAvailableDates()
    {
        return new BookingDateRange(DateTime.UtcNow, BookingDaysAhead);
    }
}