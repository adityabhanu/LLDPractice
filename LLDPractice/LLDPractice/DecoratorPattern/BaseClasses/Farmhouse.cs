using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.DecoratorPattern.BaseClasses
{
    public class Farmhouse : BasePizza
    {
        public override int cost()
        {
            return 200;
        }
    }
}
