namespace MallChargesCalculator
{
    public class FoodCourt : IRentable
    {
        public int NumberOfCounters { get; set; }
        public int Id { get; set; }
        public int SeatingCapacity { get; set; }
    }
}