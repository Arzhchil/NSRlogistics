namespace backend.Models
{
    /// <summary>
    /// Тип корабля
    /// </summary>
    public class ShipClass
    {
        public int Id { get; set; }

        /// <summary>
        /// Тип корабля
        /// </summary>
        public string ShipType { get; set; } = null!;
            
        /// <summary>
        /// Отношение к кораблю
        /// </summary>
        public List<Ship> Ship { get; set; } = null!;
        public List<test> testId { get; set; } = null!;
    }
}