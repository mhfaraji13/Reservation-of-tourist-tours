using Microsoft.EntityFrameworkCore;
using TouristReservationSystem.Application.Interfaces;
using TouristReservationSystem.Domain.Entities.Models;

namespace TouristReservationSystem.Infrastructure.Persistence;

public class TouristReservationDbContext : DbContext , ITouristReservationDbContext
{
    public TouristReservationDbContext(DbContextOptions<TouristReservationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Tour> Tours { get; set; }
    public DbSet<TourImage>  TourImages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Review>  Reviews { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tour>()
            .Property(t => t.Price)
            .HasPrecision(18, 2);
        
        modelBuilder.Entity<User>()
            .HasIndex(u=>u.Email)
            .IsUnique();
        
        modelBuilder.Entity<Booking>()
            .Property(b=>b.TotalPrice)
            .HasPrecision(18, 2);
    }
}