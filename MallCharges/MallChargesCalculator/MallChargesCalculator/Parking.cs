﻿namespace MallChargesCalculator
{
    public class Parking : IRentable
    {
        public int Id { get; set; }
        public int CarCapacity { get; set; }
        public int MotorBikeCapacity { get; set; }

        public int Visit(IVisitor visitor)
        {
            return visitor.Compute(this);
        }
    }
}