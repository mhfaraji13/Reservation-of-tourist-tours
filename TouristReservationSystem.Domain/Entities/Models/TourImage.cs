namespace TouristReservationSystem.Domain.Entities.Models;

public class TourImage
{
    public Guid Id { get; set; }
    public Guid TourId { get; set; }
    public Tour Tour { get; set; }
    public string URL { get; set; }
}