using System.ComponentModel.DataAnnotations;

namespace SimpleParking.Api.Dtos;

public record VehicleDto(
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Brand,
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Model,
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Color,
    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    string Plate
)
{
    private string _type = "";

    [Required]
    [AllowedValues("CAR", "MOTORCYCLE", ErrorMessage = "Type can only be [CAR, MOTORCYCLE]")]
    public required string Type
    {
        get => _type;
        set => _type = value.ToUpper();
    }
}
