namespace Domain.PizzaDomainObjects.ConcreteDecorators
{
    using Domain.PizzaDomainObjects.Component;
    using Domain.PizzaDomainObjects.Decorator;

    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza) : base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost() + 8.55m;
        }
    }
}
