namespace MallChargesCalculator
{
    public class WaterChargesCalculatingVisitor : ChargeCalculator
    {
        protected override int CalculateShowRoomCharge(ShowRoom s)
        {
            return s.AreaInSquareFeet * 4;
        }

        protected override int CalculateStallCharge(Stall s)
        {
            return s.AreaInSquareFeet * 6;
        }

        protected override int CalculateTheaterCharge(Theater s)
        {
            return s.SeatingCapacity * 2 + 100;
        }

        protected override int CalculateMultiplexCharge(Multiplex m)
        {
            return m.NumberOfScreens * 80 + m.TotalSeatingCapacity * 2;
        }

        protected override int CalculateFoodCourtCharge(FoodCourt f)
        {
            return f.NumberOfCounters * 100 + f.SeatingCapacity * 10;
        }

        protected override int CalculateEateryCharge(Eatery f)
        {
            return f.SeatingCapacity * 100 + 1000;
        }

        protected override int CalculateAdvertisementBoardCharge(AdvertisementBoard a)
        {
            return 0;
        }

        protected override int CalculateParkingCharge(Parking p)
        {
            return p.CarCapacity + (int) (.5 * p.MotorBikeCapacity);
        }
    }
}