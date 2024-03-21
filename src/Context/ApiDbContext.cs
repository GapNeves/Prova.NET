using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Context;

public class ApiDbContext : DbContext, IApiDbContext
{
    public DbSet<Estimate> Estimates { get; set; }
    public DbSet<Piece> Pieces { get; set; }
    public DbSet<BudgetPart> BudgetParts { get; set; }
    public DbSet<Shift> Shifts { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}

    public ApiDbContext() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BudgetPart>()
            .HasOne(bp => bp.Estimate)
            .WithMany(e => e.BudgetParts)
            .HasForeignKey(bp => bp.EstimateId);

        modelBuilder.Entity<BudgetPart>()
            .HasOne(bp => bp.Piece)
            .WithMany(p => p.BudgetParts)
            .HasForeignKey(bp => bp.PieceId);
        
        modelBuilder.Entity<Shift>()
            .HasOne(s => s.Piece)
            .WithMany(p => p.Shifts)
            .HasForeignKey(s => s.PieceId);
    }
}
