namespace backend.Models
{
    public class Route
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public GraphData? Start { get; set; }
        public Guid StartId { get; set; }

        public GraphData? Finish { get; set; }
        public Guid FinishId { get; set; }

        public double? Length { get; set; }

        public StatusRoute? StatusRoute { get; set; }
    }
    public enum StatusRoute
    {
        NotEvalute = -1,
        ClearWater = 0,
        RoutingWithoutIceBreaker = 2,
        RoutingWithIceBreaker = 3
    }
}
