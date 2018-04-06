namespace Domain.PizzaDomainObjects.ConcreteDecorators
{
    using Domain.PizzaDomainObjects.Component;
    using Domain.PizzaDomainObjects.Decorator;

    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25m;
        }
    }
}
