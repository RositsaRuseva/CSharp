using MordorsCruelPlan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models
{
    public class Other : Food
    {
        private new const int PointsOfHappiness = -1;

        public Other() : base(PointsOfHappiness)
        {
        }
    }
}
