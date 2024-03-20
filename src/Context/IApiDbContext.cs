using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Context
{
    public interface IApiDbContext 
    {
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<BudgetPart> BudgetParts { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public int SaveChanges();
    }
}