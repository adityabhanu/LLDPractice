using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern.AbstractFactory
{
    public interface IUIFactory
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckBox();
    }
}
