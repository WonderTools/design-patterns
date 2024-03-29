﻿using System;
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
}