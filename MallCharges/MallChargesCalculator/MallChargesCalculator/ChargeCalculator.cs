using System;

namespace MallChargesCalculator
{
    public abstract class ChargeCalculator
    {
        public int CalculateCharge(IRentable rentable)
        {
            var type = rentable.GetType();
            if (type == typeof(ShowRoom)) return CalculateShowRoomCharge((ShowRoom) rentable);
            if (type == typeof(Stall)) return CalculateStallCharge((Stall) rentable);
            if (type == typeof(Theater)) return CalculateTheaterCharge((Theater) rentable);
            if (type == typeof(Multiplex)) return CalculateMultiplexCharge((Multiplex) rentable);
            if (type == typeof(FoodCourt)) return CalculateFoodCourtCharge((FoodCourt) rentable);
            if (type == typeof(Eatery)) return CalculateEateryCharge((Eatery) rentable);
            if (type == typeof(AdvertisementBoard))
                return CalculateAdvertisementBoardCharge((AdvertisementBoard) rentable);
            if (type == typeof(Parking)) return CalculateParkingCharge((Parking) rentable);
            throw new Exception("The charge for item is not available");
        }

        

        protected abstract int CalculateShowRoomCharge(ShowRoom s);
        protected abstract int CalculateStallCharge(Stall s);
        protected abstract int CalculateTheaterCharge(Theater t);
        protected abstract int CalculateMultiplexCharge(Multiplex m);
        protected abstract int CalculateFoodCourtCharge(FoodCourt rentable);
        protected abstract int CalculateEateryCharge(Eatery rentable);
        protected abstract int CalculateAdvertisementBoardCharge(AdvertisementBoard rentable);
        protected abstract int CalculateParkingCharge(Parking rentable);
    }
}