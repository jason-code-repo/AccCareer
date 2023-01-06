using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("TrackManufacturers")]
public class TrackManufacturer
{
    public int CareerId { get; set; }
    public int TrackId { get; set; }
    public int PrimaryManufacturerId { get; set; }
    public int SecondaryManufacturerId { get; set; }
    public int TertiaryManufacturerId { get; set; }
}