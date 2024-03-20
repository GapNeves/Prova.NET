using src.Models;
using src.Dto;

namespace src.Repository
{
    public interface IEstimateRepository
    {
        IEnumerable<EstimateDto> GetEstimates();
        EstimateDto AddEstimate(Estimate estimate);
        EstimateDto UpdateEstimate(Estimate estimate);
    }
}