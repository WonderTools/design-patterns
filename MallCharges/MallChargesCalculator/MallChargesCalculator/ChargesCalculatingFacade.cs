using System;
using System.Security.Cryptography.X509Certificates;

namespace MallChargesCalculator
{
    public class ChargesCalculatingFacade
    {
        RentableRepository _rentableRepository = new RentableRepository();

        public void DisplayRentingCharges(int id)
        {
            var rentable = _rentableRepository.GetRentableOrNull(id);
            if (rentable == null)
            {
                Console.WriteLine("The item is not found");
                return;
            }
            Console.WriteLine("The Item is " + rentable.GetType().Name);
            Console.WriteLine("The Id is " + rentable.Id);
            Console.WriteLine("The Renting Charges are " + GetRentingCharges(rentable));
            Console.WriteLine("The Electricty Charges are " + GetElectricityCharges(rentable));
            Console.WriteLine("The Water Charges are " + GetWaterCharges(rentable));
            Console.WriteLine("The Cleaning Charges are " + GetCleaningCharges(rentable));
        }

        private int GetRentingCharges(IRentable rentable)
        {
            var rentingCalculatingVisitor = new RentCalculatingVisitor();
            return rentable.Visit(rentingCalculatingVisitor);
        }

        private int GetWaterCharges(IRentable rentable)
        {
            var waterChargesCalculatingVisitor = new WaterChargesCalculatingVisitor();
            return rentable.Visit(waterChargesCalculatingVisitor);
        }

        private int GetElectricityCharges(IRentable rentable)
        {
            var electricityChargesCalculatingVisitor = new ElectricityChargesCalculatingVisitor();
            return rentable.Visit(electricityChargesCalculatingVisitor);
        }

        private int GetCleaningCharges(IRentable rentable)
        {
            var cleaningChargesCalculatingVisitor = new CleanChargesCalculatingVisitor();
            return rentable.Visit(cleaningChargesCalculatingVisitor);
        }
    }

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