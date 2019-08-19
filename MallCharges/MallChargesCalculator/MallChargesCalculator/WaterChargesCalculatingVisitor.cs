namespace MallChargesCalculator
{
    public class WaterChargesCalculatingVisitor : IVisitor
    {
        public int Compute(ShowRoom s)
        {
            return s.AreaInSquareFeet * 4;
        }

        public int Compute(Stall s)
        {
            return s.AreaInSquareFeet * 6;
        }

        public int Compute(Theater s)
        {
            return s.SeatingCapacity * 2 + 100;
        }

        public int Compute(Multiplex m)
        {
            return m.NumberOfScreens * 80 + m.TotalSeatingCapacity * 2;
        }

        public int Compute(FoodCourt f)
        {
            return f.NumberOfCounters * 100 + f.SeatingCapacity * 10;
        }

        public int Compute(Eatery f)
        {
            return f.SeatingCapacity * 100 + 1000;
        }

        public int Compute(AdvertisementBoard a)
        {
            return 0;
        }

        public int Compute(Parking p)
        {
            return p.CarCapacity + (int) (.5 * p.MotorBikeCapacity);
        }
    }
}