using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleParking.Api.Dtos;
using SimpleParking.Api.Models;

namespace SimpleParking.Api.Controllers;

[ApiController]
[Route("api/v1/vehicles")]
public class VehicleController(AppDbContext context) : Controller
{
    [HttpGet]
    public async Task<IEnumerable<Vehicle>> Index()
    {
        return await context.Vehicles.ToListAsync();
    }

    [HttpGet("{id:guid}")]
    public async Task<Vehicle?> Show(Guid id)
    {
        return await context.Vehicles.FindAsync(id);
    }

    [HttpPost]
    public async Task<NoContentResult> Store(VehicleDto vehicleDto)
    {
        var vehicle = new Vehicle
        {
            Brand = vehicleDto.Brand,
            Model = vehicleDto.Model,
            Color = vehicleDto.Color,
            Plate = vehicleDto.Plate,
            Type = vehicleDto.Type
        };

        await context.Vehicles.AddAsync(vehicle);
        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public async Task<StatusCodeResult> Update(Guid id, VehicleDto vehicleDto)
    {
        var vehicle = await context.Vehicles.FindAsync(id);

        if (vehicle == null) return NotFound();

        vehicle.Brand = vehicleDto.Brand;
        vehicle.Model = vehicleDto.Model;
        vehicle.Color = vehicleDto.Color;
        vehicle.Plate = vehicleDto.Plate;
        vehicle.Type = vehicleDto.Type;

        await context.SaveChangesAsync();

        return NoContent();
    }


    [HttpDelete("{id:guid}")]
    public async Task<StatusCodeResult> Delete(Guid id)
    {
        var vehicle = await context.Vehicles.FindAsync(id);

        if (vehicle == null) return NotFound();

        context.Vehicles.Remove(vehicle);
        await context.SaveChangesAsync();

        return NoContent();
    }
}
