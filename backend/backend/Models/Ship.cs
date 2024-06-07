namespace backend.Models
{
    /// <summary>
    /// Параметры корабля
    /// </summary>
    public class Ship
    {
        public int Id { get; set; }

        /// <summary>
        /// Имя корабля
        /// </summary>
        public string ShipName { get; set; } = null!;

        /// <summary>
        /// Отношение к классу корабля
        /// </summary>
        public ShipClass ShipClass { get; set; } = null!;

        /// <summary>
        /// Скорость
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Тип проходимости
        /// </summary>
        public TypeIceClass TypeIceClass { get; set; }
    }
    public enum TypeIceClass
    {
        Class1,
        Class2,
        Class3
    }
}
