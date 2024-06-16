namespace backend.DTOs
{
    public class FindPointsDTO
    {   
        public List<Guid> FileIds { get; set; } = new List<Guid>();
        public List<GraphDataDTO> GraphDataPoints { get; set; } = new List<GraphDataDTO>();
    }
}
