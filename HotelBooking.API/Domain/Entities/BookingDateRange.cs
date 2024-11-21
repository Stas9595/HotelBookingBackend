namespace HotelBooking.API.Domain.Entities;

public class BookingDateRange(DateTime currentDate, int daysAhead)
{
    public DateTime MinDate { get; } = currentDate.Date;
    public DateTime MaxDate { get; } = currentDate.Date.AddDays(daysAhead);
}