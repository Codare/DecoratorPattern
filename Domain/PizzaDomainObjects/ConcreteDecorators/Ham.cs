namespace Domain.PizzaDomainObjects.ConcreteDecorators
{
    using Domain.PizzaDomainObjects.Component;
    using Domain.PizzaDomainObjects.Decorator;

    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost() + 5.25m;
        }
    }
}
