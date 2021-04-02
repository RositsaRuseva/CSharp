using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private const double BASE_HEALTH = 50;
        private const double BASE_ARMOR = 25;
        private const double ABILITY_POINTS = 40;
        public Priest(string name) 
            : base(name, BASE_HEALTH, BASE_ARMOR, ABILITY_POINTS, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
            else if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
            else
            {
                character.Health += this.AbilityPoints;

                if (character.Health > character.BaseHealth)
                {
                    character.Health = character.BaseHealth;
                }
            }
        }
    }
}
