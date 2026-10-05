using LLDPractice.DecoratorPattern.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.DecoratorPattern.DecoratorClasses
{
    public class Mushroom : ToppingDecorator
    {
        BasePizza basePizza;

        public Mushroom(BasePizza _basePizza)
        {
            this.basePizza = _basePizza;
        }

        public override int cost()
        {
            return this.basePizza.cost() + 60;
        }
    }
}
