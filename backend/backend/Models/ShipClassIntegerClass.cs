namespace backend.Models
{
    /// <summary>
    /// Связуюший класс между тяжестью льда и классом судна
    /// </summary>
    public class ShipClassIntegerClass
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public ShipClass ShipClass { get; set; } = null!;
        public Guid ShipClassId { get; set; }
        public IntegerIceClass IntegerIceClass { get; set; } = null!;
        public Guid IntegerIceClassId { get; set; }

        /// <summary>
        /// стоит ли снижать скорость
        /// </summary>
        public bool Debuff { get; set; }

        /// <summary>
        /// самостоятельное движение
        /// </summary>
        public bool IsCanSoloMove { get; set; }

        /// <summary>
        /// сопровождение
        /// </summary>
        public bool IsCanHelpMove { get; set; }

        /// <summary>
        /// Процент снижения скорости(в обратную, где 1 == не снижается)
        /// </summary>
        public double? DebuffValue { get; set; }

        /// <summary>
        /// Ограничение скорости под проводкой(ограничение 20% от собственной максимальной если под проводкой)
        /// </summary>
        public double? DebuffHelpValue { get; set; }
    }
}
