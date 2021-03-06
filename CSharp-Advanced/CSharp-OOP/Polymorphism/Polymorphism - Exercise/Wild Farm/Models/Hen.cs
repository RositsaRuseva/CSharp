using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double WEIGHT_PER_FOOD = 0.35;
        private const string SOUND = "Cluck";

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => WEIGHT_PER_FOOD;

        protected override bool IsFoodValid(Food food) => true;

        public override string ProduceSound() => SOUND;

    }
}

