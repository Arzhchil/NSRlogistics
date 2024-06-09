using backend.Models;
using System.Text.Json.Serialization;

namespace backend.DTOs
{
    public class ShipCrudDTO
    {
        /// <summary>
        /// Имя корабля
        /// </summary>
        public string ShipName { get; set; } = null!;

        /// <summary>
        /// Отношение к классу корабля
        /// </summary>
        [JsonIgnore]
        public ShipClass? ShipClass { get; set; }

        /// <summary>
        /// Скорость
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Gets or sets the ship class identifier.
        /// </summary>
        /// <value>
        /// The ship class identifier.
        /// </value>
        public Guid ShipClassId { get; set; } = Guid.Empty;
    }
}
