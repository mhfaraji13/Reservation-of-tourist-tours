using Microsoft.EntityFrameworkCore;
using TouristReservationSystem.Domain.Entities.Models;

namespace TouristReservationSystem.Application.Interfaces;

public interface ITouristReservationDbContext
{
    DbSet<Tour> Tours { get; }
    DbSet<TourImage>  TourImages { get; }
    DbSet<User> Users { get; }
    DbSet<Booking> Bookings { get; }
    DbSet<Review> Reviews { get; }
    DbSet<BlogPost> BlogPosts { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}


