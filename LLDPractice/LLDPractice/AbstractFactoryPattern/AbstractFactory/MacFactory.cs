using LLDPractice.AbstractFactoryPattern.Classes.Classes;
using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.AbstractFactory
{
    internal class MacFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckBox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
