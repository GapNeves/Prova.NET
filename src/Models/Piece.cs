using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Enums;

namespace src.Models;

public class Piece
{
    [Key]
    public int PieceId { get; set; }
    public int Store { get; set; }
    public string? NamePiece { get; set; }
    public ICollection<Shift> Shifts { get; set; }
    public ICollection<BudgetPart> BudgetParts { get; set; }

    public Piece()
    {
        BudgetParts = new Collection<BudgetPart>();
        Shifts = new Collection<Shift>();
    }
}