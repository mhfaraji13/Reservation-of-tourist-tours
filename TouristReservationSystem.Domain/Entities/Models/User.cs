using TouristReservationSystem.Domain.Enums;

namespace TouristReservationSystem.Domain.Entities.Models;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }
    public DateTime BirthDate { get; set; }
    public string? ProfilePicturePath { get; set; }
    public UserRole Role { get; set; }
    public bool IsActive { get; set; }
    public DateTime RegisteredAt { get; set; }


    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}