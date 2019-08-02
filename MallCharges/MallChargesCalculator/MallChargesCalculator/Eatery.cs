namespace MallChargesCalculator
{
    public class Eatery : IRentable
    {
        public int Id { get; set; }
        public int SeatingCapacity { get; set; }

        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}