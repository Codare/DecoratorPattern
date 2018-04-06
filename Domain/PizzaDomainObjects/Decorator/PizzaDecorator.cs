namespace Domain.PizzaDomainObjects.Decorator
{
    using Domain.PizzaDomainObjects.Component;

    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
