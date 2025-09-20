using System.ComponentModel.DataAnnotations;

namespace SimpleParking.Api.Dtos;

public record EstablishmentDto(
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Name,
    [Required]
    [Length(14, 14)]
    [RegularExpression("^\\d{14}$", ErrorMessage = "CNPJ must be 14 digits, numbers only")]
    string Cnpj,
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Address,
    [Required] [Range(0, 10000)] int MotorcycleParkingSpaces,
    [Required] [Range(0, 10000)] int CarParkingSpaces
)
{
}
