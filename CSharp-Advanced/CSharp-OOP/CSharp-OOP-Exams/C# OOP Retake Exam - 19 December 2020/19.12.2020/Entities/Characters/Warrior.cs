using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private const double BASE_HEALTH = 100;
        private const double BASE_ARMOR = 50;
        private const double ABILITY_POINTS = 40;

        public Warrior(string name) 
            : base(name, BASE_HEALTH, BASE_ARMOR, ABILITY_POINTS, new Satchel())
        {
        }

        public void Attack(Character character)
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
                if (this == character)
                {
                    throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                }

                character.TakeDamage(this.AbilityPoints);
            }
        }
    }
}
