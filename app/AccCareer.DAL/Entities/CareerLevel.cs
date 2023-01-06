using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("CareerLevels")]
public class CareerLevel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MinPoints { get; set; }
}