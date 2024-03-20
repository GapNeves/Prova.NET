using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models;

public class Estimate
{
    [Key]
    public int EstimateId { get; set; }
    public string? Plate { get; set; }
    public string? ClientName { get; set; }
    public ICollection<BudgetPart> BudgetParts { get; set; }

    public Estimate()
    {
        BudgetParts = new Collection<BudgetPart>();
    }
}
