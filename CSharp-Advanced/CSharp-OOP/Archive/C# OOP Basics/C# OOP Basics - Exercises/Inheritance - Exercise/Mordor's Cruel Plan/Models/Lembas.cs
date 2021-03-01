using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Lembas : Food
    {
        private const int pointsOfHappiness = 3;

        public Lembas() : base(pointsOfHappiness)
        {
        }
    }
}
