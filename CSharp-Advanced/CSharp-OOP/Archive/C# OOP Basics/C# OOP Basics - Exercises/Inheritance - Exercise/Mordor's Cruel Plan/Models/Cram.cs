using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Cram : Food
    {
        private const int pointsOfHappiness = 2;

        public Cram() : base(pointsOfHappiness)
        {
        }
    }
}
