using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleParking.Api.Models;

namespace SimpleParking.Api.Controllers;

[ApiController]
[Route("api/v1/establishments")]
public class EstablishmentController : Controller
{
    [HttpGet]
    public async Task<IEnumerable<Establishment>> Index(AppDbContext context)
    {
        return await context.Establishments.ToListAsync();
    }
}
