namespace backend.Models
{
    /// <summary>
    /// Эксель табличка ГрафДанные
    /// </summary>
    public class GraphData
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Широта
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Точка старта
        /// </summary>
        public string PointName { get; set; } = string.Empty;

        /// <summary>
        /// обозначение на картинке
        /// </summary>
        public int RepId { get; set; }
    }
}
