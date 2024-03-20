using src.Models;
using src.Dto;
using src.Context;

namespace src.Repository
{
    public class EstimateRepository
    {
        protected readonly ApiDbContext _context;
        public EstimateRepository(ApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EstimateDto> GetEstimates()
        {
            var estimates = _context.Estimates.Select(estimate => new EstimateDto
            {
                EstimateId = estimate.EstimateId,
                Plate = estimate.Plate,
                ClientName = estimate.ClientName
            });

            return estimates;
        }
    }
}