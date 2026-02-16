namespace TouristReservationSystem.Domain.Entities.Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string? ImageURL { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string AuthorName { get; set; }
}