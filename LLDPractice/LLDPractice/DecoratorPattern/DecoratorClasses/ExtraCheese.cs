using LLDPractice.DecoratorPattern.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.DecoratorPattern.DecoratorClasses
{
    public class ExtraCheese : ToppingDecorator
    {
        BasePizza basePizza;

        public ExtraCheese(BasePizza _basePizza)
        {
            this.basePizza = _basePizza;
        }

        public override int cost()
        {
            return this.basePizza.cost() + 50; 
        }
    }
}
