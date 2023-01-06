namespace AccCareer.DAL.Entities;

public class Car
{
    public int Id { get; set; }
    public int ManufacturerId { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int CarClassId { get; set; }
    public int IsEnabled { get; set; }
}