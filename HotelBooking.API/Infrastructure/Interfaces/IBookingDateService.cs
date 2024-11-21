using HotelBooking.API.Domain.Entities;

namespace HotelBooking.API.Infrastructure.Services;

public interface IBookingDateService
{
    BookingDateRange GetAvailableDates();
}