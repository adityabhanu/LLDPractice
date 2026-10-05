using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern.DriveStrategy
{
    public class SportsDrive : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Sports drive initiated");
        }
    }
}
