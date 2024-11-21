using HotelBooking.API.Domain.Entities;
using HotelBooking.API.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpPost]
    public ActionResult<Reservation> Create([FromBody] ReservationCreateRequest request)
    {
        try
        {
            var reservation = _reservationService.CreateReservation(
                request.GuestName,
                request.CheckInDate,
                request.CheckOutDate,
                request.SpecialRequests
            );

            return CreatedAtAction(nameof(GetById), new { id = reservation.Id }, reservation);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpGet("{id:guid}")]
    public ActionResult<Reservation> GetById(Guid id)
    {
        var reservation = _reservationService.GetReservationById(id);
        if (reservation == null)
        {
            return NotFound();
        }

        return Ok(reservation);
    }
}