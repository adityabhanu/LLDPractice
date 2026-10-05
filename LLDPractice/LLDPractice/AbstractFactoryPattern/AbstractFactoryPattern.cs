using LLDPractice.AbstractFactoryPattern.AbstractFactory;
using LLDPractice.AbstractFactoryPattern.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LLDPractice.AbstractFactoryPattern
{
    public class AbstractFactoryPattern
    {
        public IUIFactory factory;
        public string os;

        public AbstractFactoryPattern(string _os) {
            
            this.os = _os;

            if(os == "WINDOWS")
            {
                this.factory = new WindowsFactory();
            }
            else
            {
                this.factory= new MacFactory();
            }
        }

        public void main()
        {
            IButton button = this.factory.CreateButton();
            ICheckBox checkbox = this.factory.CreateCheckBox();

            button.Render();
            checkbox.Render();

        }
    }
}
