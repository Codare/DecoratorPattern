namespace ConsoleApp.DecoratorPatternUsage
{
    using System;
    using Domain.PizzaDomainObjects.Component;
    using Domain.PizzaDomainObjects.ConcreteComponents;
    using Domain.PizzaDomainObjects.ConcreteDecorators;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadLine();
        }
    }
}