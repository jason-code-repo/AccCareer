using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("CarClasses")]
public class CarClass
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MinPoints { get; set; }
    public int MaxPoints { get; set; }
}