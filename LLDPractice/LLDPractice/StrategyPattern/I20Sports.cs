using LLDPractice.StrategyPattern.DriveStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern
{
    public class I20Sports : Vehicle
    {
        public I20Sports() : base(new SportsDrive())
        {

        }
    }
}
