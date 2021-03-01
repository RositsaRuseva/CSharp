using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Models.Contracts
{
    public abstract class Mood
    {
        private int happinessPoints;

        public Mood(int happinessPoints)
        {
            this.happinessPoints = happinessPoints;
        }
    }
}
