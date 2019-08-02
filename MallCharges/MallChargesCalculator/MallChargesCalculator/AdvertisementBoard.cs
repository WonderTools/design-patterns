namespace MallChargesCalculator
{
    public class AdvertisementBoard : IRentable
    {
        public int Id { get; set; }
        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }

        public int AreaInSquareFeet { get; set; }
    }
}