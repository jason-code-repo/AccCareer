namespace AccCareer.DAL.Entities;

public class Track
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IsEnabled { get; set; }
    public int IsGt3Enabled { get; set; }
    public int Is6HourRated { get; set; }
    public int Is12HourRated { get; set; }
    public int Is24HourRated { get; set; }
}