namespace backend.Models
{
    public class Route
    {
        public Guid Id { get; set; } = new Guid();

        public GraphData? Start { get; set; }
        public Guid StartId { get; set; }

        public GraphData? Finish { get; set; }
        public Guid FinishId { get; set; }
    }
}
