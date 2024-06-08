namespace backend.Models
{
    public class IntegerIceClass
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// минимальная скорость
        /// </summary>
        public int MinSpeed { get; set; }

        /// <summary>
        /// максимальная скорость
        /// </summary>
        public int MaxSpeed { get; set; }
        public List<ShipClassIntegerClass> ShipClassIntegerClasses { get; set; } = new List<ShipClassIntegerClass>();
    }
}
