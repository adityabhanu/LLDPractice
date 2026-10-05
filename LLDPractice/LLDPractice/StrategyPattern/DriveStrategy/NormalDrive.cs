using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern.DriveStrategy
{
    public class NormalDrive : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Normal Drive Initiated");
        }
    }
}
