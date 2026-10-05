using LLDPractice.AbstractFactoryPattern.Classes.Classes;
using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.AbstractFactory
{
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox() {
            return new WindowsCheckbox();
        }
    }
}
