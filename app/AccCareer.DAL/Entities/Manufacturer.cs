using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("Manufacturers")]
public class Manufacturer
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}