using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("piece")]

    public class PieceController : Controller
    {
        private readonly ILogger<PieceController> _logger;
        private readonly ApiDbContext _context;

        public PieceController(ILogger<PieceController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }    
    }

}