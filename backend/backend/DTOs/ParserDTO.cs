namespace backend.DTOs
{
    public class ParserDTO
    {
        public Guid FileId { get; set; }

        public int WorkBookSheet { get; set; } = 1;
    }
}
