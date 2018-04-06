namespace Domain.PizzaDomainObjects.ConcreteComponents
{
    using Domain.PizzaDomainObjects.Component;

    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 3.00m;
        }
    }
}