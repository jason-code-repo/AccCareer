namespace AccCareer.DAL.Entities;

public class TrackManufacturer
{
    public int CareerId { get; set; }
    public int TrackId { get; set; }
    public int PrimaryManufacturerId { get; set; }
    public int SecondaryManufacturerId { get; set; }
    public int TertiaryManufacturerId { get; set; }
}