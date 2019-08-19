namespace MallChargesCalculator
{
    public class CleanChargesCalculatingVisitor : ChargeCalculator
    {
        protected override int CalculateShowRoomCharge(ShowRoom s)
        {
            return s.AreaInSquareFeet;
        }

        protected override int CalculateStallCharge(Stall s)
        {
            return s.AreaInSquareFeet;
        }

        protected override int CalculateTheaterCharge(Theater s)
        {
            return s.SeatingCapacity * 10;
        }

        protected override int CalculateMultiplexCharge(Multiplex m)
        {
            return m.TotalSeatingCapacity * 10;
        }

        protected override int CalculateFoodCourtCharge(FoodCourt f)
        {
            return f.SeatingCapacity * 25;
        }

        protected override int CalculateEateryCharge(Eatery f)
        {
            return f.SeatingCapacity * 25;
        }

        protected override int CalculateAdvertisementBoardCharge(AdvertisementBoard a)
        {
            return 50;
        }

        protected override int CalculateParkingCharge(Parking rentable)
        {
            return 2000;
        }
    }
}