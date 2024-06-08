namespace backend.Models
{
    /// <summary>
    /// накидываем
    /// </summary>
    public class ShipClassIntegerClass
    {
        public int Id { get; set; }
        public ShipClass ShipClass { get; set; } = null!;
        public int ShipClassId { get; set; }
        public IntegerIceClass IntegerIceClass { get; set; } = null!;
        public int IntegerIceClassId { get; set; }
        public bool Debuff { get; set; }
        public bool IsCanMove { get; set; }
        public double? DebuffValue { get; set; }
    }
}
