using LLDPractice.StrategyPattern.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern
{
    public class Waganor : Vehicle
    {
        public Waganor() : base(new NormalDrive())
        {
        }
    }
}
