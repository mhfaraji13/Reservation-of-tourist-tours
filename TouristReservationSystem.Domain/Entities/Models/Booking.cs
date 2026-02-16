using TouristReservationSystem.Domain.Enums;

namespace TouristReservationSystem.Domain.Entities.Models;

public class Booking
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }

    public int PassengerCount { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime ReservedAt { get; set; } = DateTime.Now;
    public BookingStatus Status { get; set; }
}