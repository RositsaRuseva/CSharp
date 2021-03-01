using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Mushrooms : Food
    {
        private const int pointsOfHappiness = -10;

        public Mushrooms() : base(pointsOfHappiness)
        {
        }
    }
}
