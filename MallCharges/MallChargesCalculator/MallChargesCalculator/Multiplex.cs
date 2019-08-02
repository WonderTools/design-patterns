namespace MallChargesCalculator
{
    public class Multiplex : IRentable
    {
        public int TotalSeatingCapacity { get; set; }
        public int Id { get; set; }
        public int NumberOfScreens { get; set; }

        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}