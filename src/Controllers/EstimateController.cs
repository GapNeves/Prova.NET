using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Repository;
using src.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("estimates")]

    public class EstimateController : Controller
    {
        private readonly ILogger<EstimateController> _logger;
        private readonly IEstimateRepository _repository;

        public EstimateController(
            ILogger<EstimateController> logger,
            IEstimateRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetEstimates()
        {
            return Ok(_repository.GetEstimates());
        }
    }
}
