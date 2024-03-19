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
    public DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured) return;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<State>()
            .HasKey(s => new { s.EstimateId, s.PieceId });
    }
}
