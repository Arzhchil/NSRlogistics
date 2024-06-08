namespace backend.Models
{
    public class Route
    {
        public Guid Id { get; set; } = new Guid();

        public GraphData Start { get; set; }
        public int StartId { get; set; }

        public GraphData Finish { get; set; }
        public int FinishId { get; set; }
    }
}
