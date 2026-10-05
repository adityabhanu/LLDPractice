using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.DecoratorPattern.BaseClasses
{
    public class VegDelight : BasePizza
    {
        public override int cost()
        {
            return 150;
        }
    }
}
