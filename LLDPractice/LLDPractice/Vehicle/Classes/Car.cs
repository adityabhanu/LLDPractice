using LLDPractice.Vehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.Vehicle.Classes
{
    public class Car : Vehicle, IEngineVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void StartEngine()
        {
            Console.WriteLine("Car Enginer Started");
        }
    }
}
