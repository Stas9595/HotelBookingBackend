using HotelBooking.API.Domain.Entities;
using HotelBooking.API.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController(IBookingDateService bookingDateService) : ControllerBase
{
    [HttpGet("available-dates")]
    public ActionResult<AvailableDatesDto> GetAvailableDates()
    {
        var dateRange = bookingDateService.GetAvailableDates();
        return Ok(new AvailableDatesDto(dateRange));
    }
}