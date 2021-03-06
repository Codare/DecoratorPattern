﻿namespace Domain.PizzaDomainObjects.ConcreteComponents
{
    using Component;

    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 9.00m;
        }
    }
}
