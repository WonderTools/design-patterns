namespace MallChargesCalculator
{
    public class CleanChargesCalculatingVisitor : IVisitor
    {
        public int Compute(ShowRoom s)
        {
            return s.AreaInSquareFeet;
        }

        public int Compute(Stall s)
        {
            return s.AreaInSquareFeet;
        }

        public int Compute(Theater s)
        {
            return s.SeatingCapacity * 10;
        }

        public int Compute(Multiplex m)
        {
            return m.TotalSeatingCapacity * 10;
        }

        public int Compute(FoodCourt f)
        {
            return f.SeatingCapacity * 25;
        }

        public int Compute(Eatery f)
        {
            return f.SeatingCapacity * 25;
        }

        public int Compute(AdvertisementBoard a)
        {
            return 50;
        }

        public int Compute(Parking p)
        {
            return 2000;
        }
    }
}