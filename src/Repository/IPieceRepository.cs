using src.Models;
using src.Dto;

namespace src.Repository
{
    public interface IPieceRepository
    {
        IEnumerable<PieceDto> GetPieces();
        PieceDto AddPiece(Piece piece);
        PieceDto UpdatePiece(Piece piece);
    }
}