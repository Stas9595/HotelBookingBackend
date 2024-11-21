namespace HotelBooking.API.Domain.Entities;

public record Reservation
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string GuestName { get; init; }
    public required DateTime CheckInDate { get; init; }
    public required DateTime CheckOutDate { get; init; }
    public string? SpecialRequests { get; init; }
    
    
    public void Validate()
    {
        if (CheckOutDate <= CheckInDate)
        {
            throw new ArgumentException("Check-out date must be later than check-in date.");
        }
    }
}