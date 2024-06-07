namespace backend.Models
{
    /// <summary>
    /// Эксель табличка ГрафДанные
    /// </summary>
    public class GraphData
    {
        public int Id { get; set; }

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
