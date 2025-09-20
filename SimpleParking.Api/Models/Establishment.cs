using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SimpleParking.Api.Models;

[Index(nameof(Cnpj), IsUnique = true)]
public class Establishment
{
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(255)] public string Name { get; set; } = string.Empty;
    [MaxLength(255)] public string Cnpj { get; set; } = string.Empty;
    [MaxLength(255)] public string Address { get; set; } = string.Empty;
    public int MotorcycleParkingSpaces { get; set; } = 0;
    public int CarParkingSpaces { get; set; } = 0;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
}
