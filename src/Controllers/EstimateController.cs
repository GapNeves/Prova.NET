using Microsoft.AspNetCore.Mvc;
using src.Data;

namespace src.Controllers
{
    [ApiController]
    [Route("estimate")]

    public class EstimateController : Controller
    {
        private readonly ILogger<EstimateController> _logger;
        private readonly ApiDbContext _context;

        public EstimateController(ILogger<EstimateController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}