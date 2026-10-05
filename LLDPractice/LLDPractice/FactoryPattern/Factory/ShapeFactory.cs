using LLDPractice.FactoryPattern.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.FactoryPattern.Factory
{
    public class ShapeFactory
    {
        public IShape getShape(string input)
        {
            switch (input)
            {
                case "CIRCLE":
                    return new Circle();
                case "RECTANGLE":
                    return new Rectangle();
                default:
                    throw new ArgumentException($"Unknown input shape: {input}");
            }
        } 
    }
}
