using System.Collections.Generic;
using System.Linq;

namespace MallChargesCalculator
{
    public class RentableRepository
    {
        private List<IRentable> _rentables = new List<IRentable>()
        {
            new ShowRoom(){ Id = 101, AreaInSquareFeet = 2000 },
            new ShowRoom() {Id = 102, AreaInSquareFeet = 2500 },
            new Stall() {Id = 103, AreaInSquareFeet = 80},
            new Theater() {Id = 104, SeatingCapacity = 280},
            new Multiplex() {Id = 105, NumberOfScreens = 5, TotalSeatingCapacity = 900},
            new FoodCourt() {Id = 106, NumberOfCounters = 10, SeatingCapacity = 300 },
            new Eatery() {Id = 107, SeatingCapacity = 40},
            new AdvertisementBoard() {Id = 108, AreaInSquareFeet = 30},
            new AdvertisementBoard() {Id = 109, AreaInSquareFeet = 40},
            new AdvertisementBoard() {Id = 110, AreaInSquareFeet = 40},
            new AdvertisementBoard() {Id = 111, AreaInSquareFeet = 30},
            new Parking(){Id = 112, CarCapacity = 50, MotorBikeCapacity = 150},
            new ShowRoom(){ Id = 201, AreaInSquareFeet = 2000 },
            new ShowRoom() {Id = 302, AreaInSquareFeet = 2500 },
            new Stall() {Id = 203, AreaInSquareFeet = 80},
            new Theater() {Id = 204, SeatingCapacity = 280},
            new Multiplex() {Id = 205, NumberOfScreens = 5, TotalSeatingCapacity = 900},
            new FoodCourt() {Id = 206, NumberOfCounters = 10, SeatingCapacity = 300 },
            new Eatery() {Id = 207, SeatingCapacity = 40},
            new AdvertisementBoard() {Id = 208, AreaInSquareFeet = 30},
            new AdvertisementBoard() {Id = 209, AreaInSquareFeet = 40},
            new AdvertisementBoard() {Id = 210, AreaInSquareFeet = 40},
            new AdvertisementBoard() {Id = 211, AreaInSquareFeet = 30},
            new Parking(){Id = 212, CarCapacity = 50, MotorBikeCapacity = 150},
        };

        private Dictionary<int,IRentable> _rentableDictionary = new Dictionary<int, IRentable>();

        public RentableRepository()
        {
            _rentableDictionary = _rentables.ToDictionary(x => x.Id, x => x);
        }

        public IRentable GetRentableOrNull(int id)
        {
            if (_rentableDictionary.ContainsKey(id)) return _rentableDictionary[id];
            return null;
        }
    }
}