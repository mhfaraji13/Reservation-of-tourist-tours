namespace TouristReservationSystem.Domain.Entities.Models;

public class Tour
{
    public Guid Id { get; set; }
    public string TourName { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public string Duration { get; set; }
    public string Itinerary { get; set; }
    public string IncludedServices { get; set; }
    public string Requirements { get; set; }
    public int Capacity { get; set; }
    public DateTime EndDate { get; set; }


    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<TourImage> Images { get; set; }  = new List<TourImage>();
}