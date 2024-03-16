using Prova.Enums;

namespace Prova.Models;

public class Piece
{
    public int PieceId { get; set; }
    public int Store { get; set; }
    public string? NamePiece { get; set; }
    public TypeState State { get; set; }
}
