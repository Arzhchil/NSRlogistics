namespace backend.Models
{
    public class GraphData
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string PointName { get; set; } = string.Empty;

        /// <summary>
        /// обозначение на картинке
        /// </summary>
        public int RepId { get; set; }
    }
}
