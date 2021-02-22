using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Contracts
{
    public class Feline : Mammal
    {
        

        protected Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; }

        protected override double WeightPerFood => throw new NotImplementedException();

        public override string ProduceSound()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        protected override bool IsFoodValid(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
