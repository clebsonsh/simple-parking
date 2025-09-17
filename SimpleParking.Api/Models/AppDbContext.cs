using Microsoft.EntityFrameworkCore;

namespace SimpleParking.Api.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Establishment> Establishments { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
}
