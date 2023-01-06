namespace AccCareer.DAL.Entities;

public class CarClass
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MinPoints { get; set; }
    public int MaxPoints { get; set; }
}