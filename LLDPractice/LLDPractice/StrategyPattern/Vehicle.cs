using LLDPractice.StrategyPattern.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern
{
    public class Vehicle
    {
        IDriveStrategy driveStrategy;

        public Vehicle(IDriveStrategy _driveStrategy)
        {
            this.driveStrategy = _driveStrategy;
        }

        public void driveVehicle()
        {
            driveStrategy.drive();
        }
    }
}
