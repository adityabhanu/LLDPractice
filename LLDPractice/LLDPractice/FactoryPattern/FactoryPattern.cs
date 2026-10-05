using LLDPractice.FactoryPattern.Classes;
using LLDPractice.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.FactoryPattern
{
    // it is a creational design pattern
    // used to create objects without making the calling code responsible for the exact class being instantiated.

    // While Abstract factory is a factory of related factories. 
    public class FactoryPattern
    {
        public static void main()
        {
            try
            {
                ShapeFactory shapeFactoryObj = new ShapeFactory();
                IShape shapeObj = shapeFactoryObj.getShape("CIRCLE");
                shapeObj.draw();

                IShape shapeObj1 = shapeFactoryObj.getShape("RECTANGLE");
                shapeObj1.draw();

                IShape shapeObj2 = shapeFactoryObj.getShape("SQUARE");
                shapeObj2.draw();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
