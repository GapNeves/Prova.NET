using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Data;
using src.Repository;
using src.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("estimate")]

    public class EstimateController : Controller
    {
        private readonly ILogger<EstimateController> _logger;
        private readonly ApiDbContext _context;
        private readonly EstimateRepository _repository;

        public EstimateController(
            ILogger<EstimateController> logger,
            ApiDbContext context,
            EstimateRepository repository)
        {
            _logger = logger;
            _context = context;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetEstimates()
        {
            return Ok(_repository.GetEstimates());
        }
    }
}
