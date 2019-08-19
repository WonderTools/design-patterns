namespace MallChargesCalculator
{
    public class RentCalculatingVisitor : ChargeCalculator
    {
        protected override int CalculateShowRoomCharge(ShowRoom s)
        {
            return s.AreaInSquareFeet * 80;
        }

        protected override int CalculateStallCharge(Stall s)
        {
            return s.AreaInSquareFeet * 200;
        }

        protected override int CalculateTheaterCharge(Theater s)
        {
            return s.SeatingCapacity * 800 + 1000;
        }

        protected override int CalculateMultiplexCharge(Multiplex m)
        {
            return m.TotalSeatingCapacity * 700 + m.NumberOfScreens * 1000;
        }

        protected override int CalculateFoodCourtCharge(FoodCourt f)
        {
            return f.NumberOfCounters * 10000 + f.SeatingCapacity + 300;
        }

        protected override int CalculateEateryCharge(Eatery f)
        {
            return f.SeatingCapacity * 400 + 10000;
        }

        protected override int CalculateAdvertisementBoardCharge(AdvertisementBoard a)
        {
            return a.AreaInSquareFeet * 3;
        }

        protected override int CalculateParkingCharge(Parking p)
        {
            return p.CarCapacity * 300 + p.MotorBikeCapacity + 50;
        }
    }
}