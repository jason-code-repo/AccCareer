using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("ManufacturerInterestLevels")]
public class ManufacturerInterestLevel
{
    public int CareerId { get; set; }
    public int ManufacturerId { get; set; }
    public int InterestLevel { get; set; }
}