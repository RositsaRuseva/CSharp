using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> characterParty;
		private List<Item> itemPool;

		public WarController()
		{
			this.characterParty = new List<Character>();
			this.itemPool = new List<Item>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];

            if (characterType != "Priest" && characterType != "Warrior")
            {
				throw new ArgumentException($"Invalid character type {characterType}!");
            }

			Character character = null;

            if (characterType == "Priest")
            {
				character = new Priest(name);
            }
            else if (characterType == "Warrior")
            {
				character = new Warrior(name);
            }
			characterParty.Add(character);


			return $"{name} joined the party!";
		}

		public string AddItemToPool(string[] args)
		{
			string itemName = args[0];

            if (itemName != "FirePotion" && itemName != "HealthPotion")
            {
				throw new ArgumentException($"Invalid item {itemName}!");
            }

			Item item = null;

            if (itemName == "FirePotion")
            {
				item = new FirePotion();
            }
            else if (itemName == "HealthPotion")
            {
				item = new HealthPotion();
            }

			itemPool.Add(item);

			return $"{itemName} added to pool.";
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];

            if (this.characterParty.Any(x=>x.Name == characterName) == false)
            {
				throw new ArgumentException($"Characyer {characterName} not found!");
            }

            if (this.itemPool.Count == 0)
            {
				throw new InvalidOperationException("No items left in pool!");
            }

			Character character = characterParty.FirstOrDefault(x => x.Name == characterName);

			Item lastItem = itemPool[itemPool.Count - 1];

			character.Bag.AddItem(lastItem);
			itemPool.RemoveAt(itemPool.Count - 1);

			return $"{characterName} picked up {lastItem.GetType().Name}!";

		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];

            if (this.characterParty.Any(x=>x.Name == characterName) == false)
            {
				throw new ArgumentException($"Character {characterName} not found!");
            }

			var character = this.characterParty.FirstOrDefault(x => x.Name == characterName);
			var item = character.Bag.GetItem(itemName);

			character.UseItem(item);

			return $"{characterName} used {item.GetType().Name}";
		}

		public string GetStats()
		{
			var orderedParty = this.characterParty.OrderByDescending(x => x.IsAlive)
				.ThenByDescending(x => x.Health);

			var sb = new StringBuilder();

            foreach (var character in orderedParty)
            {
				sb.AppendLine(character.ToString());
            }
			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[1];

            if (this.characterParty.Any(x=>x.Name == attackerName) == false)
            {
				throw new ArgumentException($"Character {attackerName} not found!");
            }

            if (this.characterParty.Any(x=>x.Name == receiverName) == false)
            {
				throw new ArgumentException($"Character {receiverName} not found!");
            }

			var attacker = this.characterParty.FirstOrDefault(x => x.Name == attackerName);
			var receiver = this.characterParty.FirstOrDefault(x => x.Name == receiverName);

            if (attacker.GetType().Name != "Warrior")
            {
				throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

			Warrior warrior = (Warrior)attacker;

			warrior.Attack(receiver);

			var sb = new StringBuilder();

			sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (receiver.Health == 0)
            {
				sb.AppendLine($"{receiver.Name} is dead!");
            }

			return sb.ToString().TrimEnd();
		
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

            if (this.characterParty.Any(x=>x.Name == healerName) == false)
            {
				throw new ArgumentException($"Character {healerName} not found!");
            }
            if (this.characterParty.Any(x=>x.Name == healingReceiverName) == false)
            {
				throw new ArgumentException($"Character {healingReceiverName} not found!");
            }

			var healer = this.characterParty.FirstOrDefault(x => x.Name == healerName);
			var receiver = this.characterParty.FirstOrDefault(x => x.Name == healingReceiverName);

            if (healer.GetType().Name != "Priest")
            {
				throw new ArgumentException($"{healer.Name} cannot heal!");
            }

			Priest priest = (Priest)healer;

			priest.Heal(receiver);

			return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has received {receiver.Health} health now.!";
		}
	}
}
