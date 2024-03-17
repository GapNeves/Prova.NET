using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

    public DbSet<Estimate> Estimates { get; set; }
    public DbSet<Piece> Pieces { get; set; }
}