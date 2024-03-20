using src.Enums;

namespace src.Dto
{
    public class BudgetPartsDto
    {
        public int BudgetPartId { get; set; }
        public int EstimateId { get; set; }
        public int PieceId { get; set; }
        public int Quantity { get; set; }
        public TypeState Status { get; set; }
    }
}