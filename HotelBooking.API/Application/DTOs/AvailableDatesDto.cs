namespace HotelBooking.API.Domain.Entities;

public class AvailableDatesDto(BookingDateRange dateRange)
{
    public string MinDate { get; set; } = dateRange.MinDate.ToString("yyyy-MM-dd");
    public string MaxDate { get; set; } = dateRange.MaxDate.ToString("yyyy-MM-dd");
}