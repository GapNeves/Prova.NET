using src.Models;
using src.Dto;
using src.Context;

namespace src.Repository
{
    public class EstimateRepository : IEstimateRepository
    {
        protected readonly IApiDbContext _context;
        public EstimateRepository(IApiDbContext context)
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

        public EstimateDto AddEstimate(Estimate estimate)
        {
            _context.Estimates.Add(estimate);
            _context.SaveChanges();

            throw new NotImplementedException();
        }

        public EstimateDto UpdateEstimate(Estimate estimate)
        {
            throw new NotImplementedException();
        }
    }
}