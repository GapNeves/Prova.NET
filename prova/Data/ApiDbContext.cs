using Microsoft.EntityFrameworkCore;
using Prova.Models;

namespace Prova.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

    public DbSet<Estimate> Estimates { get; set; }
    public DbSet<Piece> Pieces { get; set; }
}