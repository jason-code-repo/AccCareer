using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("Cars")]
public class Car
{
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Model { get; set; } = null!;
    public int Year { get; set; }
    public int CarClassId { get; set; }
    public int IsEnabled { get; set; }
}