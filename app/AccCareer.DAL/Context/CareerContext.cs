using System.Data.SqlTypes;
using AccCareer.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccCareer.DAL.Context;

public class CareerContext : DbContext
{
    public CareerContext(DbContextOptions<CareerContext> options) : base(options)
    {
        
    }
    
    public DbSet<Career> Cars { get; set; }
    public DbSet<CarClass> CarClasses { get; set; }
    public DbSet<Career> Careers { get; set; }
    public DbSet<CareerLevel> CareerLevels { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<ManufacturerInterestLevel> ManufacturerInterestLevels { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<TrackManufacturer> TrackManufacturers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<CarClass>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<CareerLevel>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<Manufacturer>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<ManufacturerInterestLevel>()
            .HasKey(x => new {x.CareerId, x.ManufacturerId});
        
        modelBuilder.Entity<Track>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<TrackManufacturer>()
            .HasKey(x => new {x.CareerId, x.TrackId});
    }
}