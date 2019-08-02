namespace MallChargesCalculator
{
    public class Theater : IRentable
    {
        public int SeatingCapacity { get; set; }
        public int Id { get; set; }
        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}