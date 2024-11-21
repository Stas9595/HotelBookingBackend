using System.ComponentModel.DataAnnotations;

namespace HotelBooking.API.Domain.Entities;

public class ReservationCreateRequest
{
    [Required]
    public string GuestName { get; init; } = null!;

    [Required]
    public DateTime CheckInDate { get; init; }

    [Required]
    public DateTime CheckOutDate { get; init; }

    public string? SpecialRequests { get; init; }
}