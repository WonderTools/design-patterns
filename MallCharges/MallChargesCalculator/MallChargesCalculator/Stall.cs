namespace MallChargesCalculator
{
    public class Stall : IRentable
    {
        public int AreaInSquareFeet { get; set; }
        public int Id { get; set; }

        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}