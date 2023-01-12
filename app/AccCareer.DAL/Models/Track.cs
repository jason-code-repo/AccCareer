namespace AccCareer.DAL.Models;

public class Track
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsEnabled { get; set; }
    public bool IsGt3Enabled { get; set; }
    public bool Is6HourRated { get; set; }
    public bool Is12HourRated { get; set; }
    public bool Is24HourRated { get; set; }
}