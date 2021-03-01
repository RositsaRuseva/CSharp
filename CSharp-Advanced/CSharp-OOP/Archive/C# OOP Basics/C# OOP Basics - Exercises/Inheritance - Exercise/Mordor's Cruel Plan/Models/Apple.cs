using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Apple : Food
    {
        private const int pointsOfHappiness = 1;

        public Apple() : base(pointsOfHappiness)
        {
        }
    }
}
