using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Repository;
using src.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("pieces")]

    public class PieceController : Controller
    {
        private readonly ILogger<PieceController> _logger;
        private readonly IPieceRepository _repository;
        
        public PieceController(
            ILogger<PieceController> logger,
            IPieceRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetPieces()
        {
            return Ok(_repository.GetPieces());
        }
    }

}