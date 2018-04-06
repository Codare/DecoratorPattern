namespace Domain.PizzaDomainObjects.ConcreteComponents
{
    using Domain.PizzaDomainObjects.Component;

    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 6.00m;
        }
    }
}