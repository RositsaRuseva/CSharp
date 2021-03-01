using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models.Contracts
{
    public abstract class Food
    {
        public Food(int pointsOfHappiness)
        {
            this.PointsOfHappiness = pointsOfHappiness;
        }

        public int PointsOfHappiness { get; private set; }
    }
}
