using AccCareer.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccCareer.DAL.Context;

public class CareerContext : DbContext
{
    private string _dbPath { get; }
    public CareerContext(DbContextOptions<CareerContext> options) : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        _dbPath = Path.Join(path, "CareerDb.db");
    }
    
    public DbSet<Career> Cars { get; set; }
    public DbSet<CarClass> CarClasses { get; set; }
    public DbSet<Career> Careers { get; set; }
    public DbSet<CareerLevel> CareerLevels { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<ManufacturerInterestLevel> ManufacturerInterestLevels { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<TrackManufacturer> TrackManufacturers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={_dbPath}");

}