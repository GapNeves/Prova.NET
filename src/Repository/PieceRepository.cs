using src.Models;
using src.Dto;
using src.Context;

namespace src.Repository
{
    public class PieceRepository
    {
        protected readonly ApiDbContext _context;
        public PieceRepository(ApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PieceDto> GetPieces()
        {
            var pieces = _context.Pieces.Select(piece => new PieceDto
            {
                PieceId = piece.PieceId,
                Store = piece.Store,
                NamePiece = piece.NamePiece
            });

            return pieces;
        }
    }
}