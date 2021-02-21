using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Common;
using Raiding.Factories;
using Raiding.Models;

namespace Raiding.Core.Contacts
{
    public class Engine : IEngine
    {
        private readonly HeroFactory heroFactory;

        public Engine()
        {
            this.heroFactory = new HeroFactory();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> listOfHeroes = new List<BaseHero>();

            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string typeOfHero = Console.ReadLine();
                try
                {
                    BaseHero hero = CreateHero(name, typeOfHero);
                    listOfHeroes.Add(hero);
                    totalSum += hero.Power;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
            int powerOfBoss = int.Parse(Console.ReadLine());
            foreach (var hero in listOfHeroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            if (powerOfBoss <= totalSum)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
            //Console.WriteLine();
        }

        private static BaseHero CreateHero(string name, string typeOfHero)
        {

            if (CheckHero(typeOfHero) == HeroEnum.Druid)
            {
                return new Druid(name);
            }
            else if (CheckHero(typeOfHero) == HeroEnum.Paladin)
            {
                return new Paladin(name);
            }
            else if (CheckHero(typeOfHero) == HeroEnum.Rogue)
            {
                return new Rogue(name);
            }
            else
            {
                return new Warrior(name);
            }

        }
        private static HeroEnum CheckHero(string typeOfHero)
        {
            HeroEnum hero;
            if (!Enum.TryParse<HeroEnum>(typeOfHero, out hero))
            {
                throw new ArgumentException(ExceptionMessages.INVALID_HERO);
            }
            return hero;
        }
    }
}
