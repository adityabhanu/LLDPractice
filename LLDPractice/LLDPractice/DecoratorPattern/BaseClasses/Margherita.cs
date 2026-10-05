using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.DecoratorPattern.BaseClasses
{
    public class Margherita : BasePizza
    {
        public override int cost()
        {
            return 100;
        }
    }
}
