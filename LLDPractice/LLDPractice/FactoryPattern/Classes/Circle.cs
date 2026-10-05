using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.FactoryPattern.Classes
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle shape drawn");
        }
    }
}
