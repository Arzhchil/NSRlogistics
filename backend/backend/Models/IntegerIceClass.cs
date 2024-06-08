namespace backend.Models
{
    public class IntegerIceClass
    {
        public int Id { get; set; }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public List<ShipClassIntegerClass> ShipClassIntegerClasses { get; set; }
    }
}
