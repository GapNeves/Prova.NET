using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Enums;

namespace src.Models;

public class State
{
    [ForeignKey("EstimateId")]
    public int EstimateId { get; set; }

    [ForeignKey("PieceId")]
    public int PieceId { get; set; }
    public int Quantity { get; set; }
    public TypeState Status { get; set; }
}