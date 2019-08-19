namespace MallChargesCalculator
{
    public class RentCalculatingVisitor : IVisitor
    {
        public int Compute(ShowRoom s)
        {
            return s.AreaInSquareFeet * 80;
        }

        public int Compute(Stall s)
        {
            return s.AreaInSquareFeet * 200;
        }

        public int Compute(Theater s)
        {
            return s.SeatingCapacity * 800 + 1000;
        }

        public int Compute(Multiplex m)
        {
            return m.TotalSeatingCapacity * 700 + m.NumberOfScreens * 1000;
        }

        public int Compute(FoodCourt f)
        {
            return f.NumberOfCounters * 10000 + f.SeatingCapacity + 300;
        }

        public int Compute(Eatery f)
        {
            return f.SeatingCapacity * 400 + 10000;
        }

        public int Compute(AdvertisementBoard a)
        {
            return a.AreaInSquareFeet * 3;
        }

        public int Compute(Parking p)
        {
            return p.CarCapacity * 300 + p.MotorBikeCapacity + 50;
        }
    }
}