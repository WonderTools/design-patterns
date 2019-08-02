namespace MallChargesCalculator
{
    public interface IRentable
    {
        int Id { get; set; }

        int Visit(IVisitor visitor);
    }

    public interface IVisitor
    {
        int Compute(ShowRoom s);
        int Compute(Stall s);
        int Compute(Theater s);
        int Compute(Multiplex m);
        int Compute(FoodCourt f);
        int Compute(Eatery f);
        int Compute(AdvertisementBoard a);
        int Compute(Parking p);

    }
}