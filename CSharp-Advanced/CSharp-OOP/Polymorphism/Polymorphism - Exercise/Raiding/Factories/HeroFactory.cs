using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Models;
using Raiding.Common;

namespace Raiding.Factories
{
    public class HeroFactory
    {
        public HeroFactory()
        {

        }
        //public static BaseHero CreateHero(string heroType, string heroName)
        //{
        //    if (CheckHero(heroType) == HeroEnum.Druid)
        //    {
        //        return new Druid(heroName);
        //    }
        //    else if (CheckHero(heroType) == HeroEnum.Paladin)
        //    {
        //        return new Paladin(heroName);
        //    }
        //    else if (CheckHero(heroType) == HeroEnum.Rogue)
        //    {
        //        return new Rogue(heroName);
        //    }
        //    else if (CheckHero(heroType) == HeroEnum.Warrior)
        //    {
        //        return new Warrior(heroName);
        //    }
            
        //}
        //private static HeroEnum CheckHero(string heroType)
        //{
        //    HeroEnum hero;
        //    if (!Enum.TryParse<HeroEnum>(heroType, out hero))
        //    {
        //        throw new ArgumentException(ExceptionMessages.INVALID_HERO);
        //    }
        //    return hero;
        //}


    }
}
