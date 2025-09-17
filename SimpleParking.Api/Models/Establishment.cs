namespace SimpleParking.Api.Models;

public class Establishment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int MotorcycleParkingSpaces { get; set; } = 0;
    public int CarParkingSpaces { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
