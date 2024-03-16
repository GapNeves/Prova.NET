using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prova.Models;

public class Estimate
{
    [Key]
    public int EstimateId { get; set; }
    public int Number { get; set; }
    public int Plate { get; set; }
    public string? ClientName { get; set; }
    [ForeignKey("PieceId")]
    public int PieceId { get; set; }
}
