namespace MallChargesCalculator
{
    public class ShowRoom : IRentable
    {
        public int Id { get; set; }

        public int AreaInSquareFeet { get; set; }

        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}