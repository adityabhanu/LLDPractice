using LLDPractice.DecoratorPattern.BaseClasses;
using LLDPractice.DecoratorPattern.DecoratorClasses;
using System;
using System.Collections.Generic;
using System.Text;

//Decorator pattern has both is-a and has-a relationship with its Base Class
namespace LLDPractice.DecoratorPattern
{
    public class DecoratorClass
    {
        public static void main()
        {
            BasePizza pizza = new Mushroom(new ExtraCheese(new Margherita()));
            int pizzaCost = pizza.cost();
            Console.WriteLine("Pizza Cost is, {0}", pizzaCost);

            BasePizza vegPizza = new Mushroom(new ExtraCheese(new VegDelight()));
            int vegPizzaCost = vegPizza.cost();
            Console.WriteLine("Pizza Cost is, {0}", vegPizzaCost);
        }
    }
}
