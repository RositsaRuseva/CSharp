using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
        this.Name = name;
        }
        public string Name { get; }
        public virtual int Power { get; }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name}";
        }
        //public virtual string CastAbility => $"{this.GetType().Name} - {this.Name}";
    }
}
