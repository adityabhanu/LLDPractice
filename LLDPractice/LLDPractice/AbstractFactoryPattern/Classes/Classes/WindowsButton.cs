using LLDPractice.AbstractFactoryPattern.AbstractFactory;
using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.Classes.Classes
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button Rendered");
        }
    }
}
