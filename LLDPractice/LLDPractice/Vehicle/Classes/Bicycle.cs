using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.Vehicle.Classes
{
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
