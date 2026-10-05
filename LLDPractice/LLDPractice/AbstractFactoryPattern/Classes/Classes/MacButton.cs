using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.Classes.Classes
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Mac Button Rendered");
        }
    }
}
