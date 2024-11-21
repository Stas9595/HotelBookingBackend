using HotelBooking.API.Domain.Entities;

namespace HotelBooking.API.Infrastructure.Services;

public class ReservationService : IReservationService
{
    private readonly Dictionary<Guid, Reservation> _reservations = new();

    public Reservation CreateReservation(string guestName, DateTime checkInDate, DateTime checkOutDate, string? specialRequests)
    {
        var reservation = new Reservation
        {
            GuestName = guestName,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate,
            SpecialRequests = specialRequests
        };

        reservation.Validate();
        _reservations[reservation.Id] = reservation;

        return reservation;
    }

    public Reservation? GetReservationById(Guid id)
    {
        _reservations.TryGetValue(id, out var reservation);
        return reservation;
    }
}