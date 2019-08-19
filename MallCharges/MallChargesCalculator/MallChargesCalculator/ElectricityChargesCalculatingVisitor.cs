namespace MallChargesCalculator
{
    public class ElectricityChargesCalculatingVisitor : IVisitor
    {
        public int Compute(ShowRoom s)
        {
            return s.AreaInSquareFeet * 3;
        }

        public int Compute(Stall s)
        {
            return s.AreaInSquareFeet * 5;
        }

        public int Compute(Theater s)
        {
            return s.SeatingCapacity * 5 + 5000;
        }

        public int Compute(Multiplex m)
        {
            return m.TotalSeatingCapacity * 5 + m.NumberOfScreens * 5000;
        }

        public int Compute(FoodCourt f)
        {
            return f.NumberOfCounters * 100 + f.SeatingCapacity * 6;
        }

        public int Compute(Eatery f)
        {
            return f.SeatingCapacity * 6 + 1000;
        }

        public int Compute(AdvertisementBoard a)
        {
            return a.AreaInSquareFeet * 10;
        }

        public int Compute(Parking p)
        {
            return 1000;
        }
    }
}