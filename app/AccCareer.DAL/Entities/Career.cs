using System.ComponentModel.DataAnnotations.Schema;

namespace AccCareer.DAL.Entities;

[Table("Careers")]
public class Career
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Points { get; set; }
}