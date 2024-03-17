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
        [HttpGet(Name = "GetAllPiece")]
        public async Task<IActionResult> GetPiece()
        {
            var piece = new Piece()
            {
                Store = 10,
                NamePiece = "Vela do Marea",
                State = 0
            };

            _context.Add(piece);
            await _context.SaveChangesAsync();

            var allPieces = await _context.Pieces.ToListAsync();
            return Ok(allPieces);
        }
    }

}