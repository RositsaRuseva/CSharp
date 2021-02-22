using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double FOOD_WEIGHT = 0.40;
        private const string SOUND = "Woof!";

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => FOOD_WEIGHT;
        public override string ProduceSound()
        {
            return SOUND;
        }

        protected override bool IsFoodValid(Food food)
        
            => food.GetType().Name == "Meat" ? true : false;
        public override string ToString()
        {
            return $"{base.ToString()}{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

    }
}
