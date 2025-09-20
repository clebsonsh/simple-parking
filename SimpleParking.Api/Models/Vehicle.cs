using System.ComponentModel.DataAnnotations;

namespace SimpleParking.Api.Models;

public class Vehicle
{
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(255)] public string Brand { get; set; } = string.Empty;
    [MaxLength(255)] public string Model { get; set; } = string.Empty;
    [MaxLength(255)] public string Color { get; set; } = string.Empty;
    [MaxLength(255)] public string Plate { get; set; } = string.Empty;
    [MaxLength(20)] public string Type { get; set; } = string.Empty;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
}
