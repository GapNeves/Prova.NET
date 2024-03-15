using Prova.Enums;

namespace Prova.Models;

public class Peças
{
    public int Id { get; set; }
    public int Store { get; set; }
    public string? NamePiece { get; set; }
    public TypeState State { get; set; }
}
