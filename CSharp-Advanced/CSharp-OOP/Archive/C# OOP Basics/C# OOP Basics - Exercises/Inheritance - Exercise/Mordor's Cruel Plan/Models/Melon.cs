using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Melon : Food
    {
        private const int pointsOfHappiness = 1;

        public Melon() : base(pointsOfHappiness)
        {
        }
    }
}
