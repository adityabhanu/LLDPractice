using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.StrategyPattern.DriveStrategy
{
    //used where there are some common methods that might be required by multiple other classes
    public interface IDriveStrategy
    {
        public void drive();
    }
}
