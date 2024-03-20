using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Enums;

namespace src.Models;

public class BudgetPart
{   
    [Key]
    public int BudgetPartId { get; set; }
    [ForeignKey("EstimateId")]
    public int EstimateId { get; set; }
    [ForeignKey("PieceId")]
    public int PieceId { get; set; }
    public int Quantity { get; set; }
    public TypeState Status { get; set; }
    public Estimate Estimate { get; set; }
    public Piece Piece { get; set; }
}