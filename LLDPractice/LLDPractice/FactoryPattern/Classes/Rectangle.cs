using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.FactoryPattern.Classes
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle Shape Drawn");
        }
    }
}
