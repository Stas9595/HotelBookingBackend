using HotelBooking.API.Domain.Entities;

namespace HotelBooking.API.Infrastructure.Services;

public interface IReservationService
{
    Reservation CreateReservation(string guestName, DateTime checkInDate, DateTime checkOutDate, string? specialRequests);
    Reservation? GetReservationById(Guid id);
}