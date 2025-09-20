using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleParking.Api.Dtos;
using SimpleParking.Api.Models;

namespace SimpleParking.Api.Controllers;

[ApiController]
[Route("api/v1/establishments")]
public class EstablishmentController(AppDbContext context) : Controller
{
    [HttpGet]
    public async Task<IEnumerable<Establishment>> Index()
    {
        return await context.Establishments.ToListAsync();
    }

    [HttpGet("{id:guid}")]
    public async Task<Establishment?> Show(Guid id)
    {
        return await context.Establishments.FindAsync(id);
    }

    [HttpPost]
    public async Task<NoContentResult> Store(EstablishmentDto establishmentDto)
    {
        Console.Write(establishmentDto);
        var establishment = new Establishment
        {
            Name = establishmentDto.Name,
            Cnpj = establishmentDto.Cnpj,
            Address = establishmentDto.Address,
            MotorcycleParkingSpaces = establishmentDto.MotorcycleParkingSpaces,
            CarParkingSpaces = establishmentDto.CarParkingSpaces
        };

        await context.Establishments.AddAsync(establishment);
        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public async Task<StatusCodeResult> Update(Guid id, EstablishmentDto establishmentDto)
    {
        var establishment = await context.Establishments.FindAsync(id);

        if (establishment == null) return NotFound();

        establishment.Name = establishmentDto.Name;
        establishment.Cnpj = establishmentDto.Cnpj;
        establishment.Address = establishmentDto.Address;
        establishment.MotorcycleParkingSpaces = establishmentDto.MotorcycleParkingSpaces;
        establishment.CarParkingSpaces = establishmentDto.CarParkingSpaces;

        await context.SaveChangesAsync();

        return NoContent();
    }


    [HttpDelete("{id:guid}")]
    public async Task<StatusCodeResult> Delete(Guid id)
    {
        var establishment = await context.Establishments.FindAsync(id);

        if (establishment == null) return NotFound();

        context.Establishments.Remove(establishment);
        await context.SaveChangesAsync();

        return NoContent();
    }
}
