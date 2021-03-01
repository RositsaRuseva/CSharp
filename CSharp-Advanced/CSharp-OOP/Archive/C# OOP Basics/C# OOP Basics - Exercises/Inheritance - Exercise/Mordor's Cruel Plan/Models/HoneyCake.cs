using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class HoneyCake : Food
    {
        private const int pointsOfHappiness = 5;

        public HoneyCake() : base(pointsOfHappiness)
        {
        }
    }
}
