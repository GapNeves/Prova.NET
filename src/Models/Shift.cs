using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Enums;

namespace src.Models;

public class Shift
{
    [Key]
    public int ShiftId { get; set; }
    [ForeignKey("PieceId")]
    public int PieceId { get; set; }
    public int Quantity { get; set; }
    public TypeShift MovimentType { get; set; }
    public DateTime Date { get; set; }
    public Piece? Piece { get; set; }
}