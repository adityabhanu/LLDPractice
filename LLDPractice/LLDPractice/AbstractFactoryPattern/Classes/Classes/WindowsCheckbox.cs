using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.Classes.Classes
{
    public class WindowsCheckbox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Windows Checkbox Rendered");
        }
    }
}
