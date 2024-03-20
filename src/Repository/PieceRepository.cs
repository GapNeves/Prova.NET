using src.Models;
using src.Dto;
using src.Context;

namespace src.Repository
{
    public class PieceRepository : IPieceRepository
    {
        protected readonly IApiDbContext _context;
        public PieceRepository(IApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PieceDto> GetPieces()
        {
            var pieces = _context.Pieces.Select(piece => new PieceDto
            {
                PieceId = piece.PieceId,
                Store = piece.Store,
                NamePiece = piece.NamePiece,
            });

            return pieces;
        }

        public PieceDto AddPiece(Piece piece)
        {
            _context.Pieces.Add(piece);
            _context.SaveChanges();

            throw new NotImplementedException();
        }

        public PieceDto UpdatePiece(Piece piece)
        {
            throw new NotImplementedException();
        }
    }
}