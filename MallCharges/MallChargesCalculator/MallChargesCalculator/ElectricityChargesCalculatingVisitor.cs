namespace MallChargesCalculator
{
    public class ElectricityChargesCalculatingVisitor : ChargeCalculator
    {
        protected override int CalculateShowRoomCharge(ShowRoom s)
        {
            return s.AreaInSquareFeet * 3;
        }

        protected override int CalculateStallCharge(Stall s)
        {
            return s.AreaInSquareFeet * 5;
        }

        protected override int CalculateTheaterCharge(Theater s)
        {
            return s.SeatingCapacity * 5 + 5000;
        }

        protected override int CalculateMultiplexCharge(Multiplex m)
        {
            return m.TotalSeatingCapacity * 5 + m.NumberOfScreens * 5000;
        }

        protected override int CalculateFoodCourtCharge(FoodCourt f)
        {
            return f.NumberOfCounters * 100 + f.SeatingCapacity * 6;
        }

        protected override int CalculateEateryCharge(Eatery f)
        {
            return f.SeatingCapacity * 6 + 1000;
        }

        protected override int CalculateAdvertisementBoardCharge(AdvertisementBoard a)
        {
            return a.AreaInSquareFeet * 10;
        }

        protected override int CalculateParkingCharge(Parking p)
        {
            return 1000;
        }
    }
}