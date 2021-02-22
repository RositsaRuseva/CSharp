using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const double WEIGHT_PER_FOOD = 0.30;
        private const string SOUND = "Meow";

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => WEIGHT_PER_FOOD;

        protected override bool IsFoodValid(Food food) => food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat" ? true : false;

        public override string ProduceSound() => SOUND;
    }
}
