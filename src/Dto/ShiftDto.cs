using src.Enums;

namespace src.Dto
{
    public class ShiftDto
    {   
        public int ShiftId { get; set; }
        public int PieceId { get; set; }
        public int Quantity { get; set; }
        public TypeShift MovimentType { get; set; }
    }
}