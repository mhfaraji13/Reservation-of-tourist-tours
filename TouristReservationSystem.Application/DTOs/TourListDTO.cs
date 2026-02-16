namespace TouristReservationSystem.Application.DTOs;

public class TourListDTO
{
    public Guid Id { get; set; }
    public string TourName { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
    public string Duration { get; set; }
    public string? MainImageURL { get; set; }
}