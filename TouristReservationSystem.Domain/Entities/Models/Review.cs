namespace TouristReservationSystem.Domain.Entities.Models;

public class Review
{
    public Guid Id { get; set; }
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }

    public string Comment { get; set; }
    public int Rating { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}