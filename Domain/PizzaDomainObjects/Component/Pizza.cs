﻿namespace Domain.PizzaDomainObjects.Component
{
    public abstract class Pizza
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract decimal CalculateCost();
    }
}
