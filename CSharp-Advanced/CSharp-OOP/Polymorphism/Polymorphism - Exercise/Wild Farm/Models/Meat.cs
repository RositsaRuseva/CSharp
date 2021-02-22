using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public class Meat : Food
    {
        public Meat(int quantity) 
            : base(quantity)
        {
        }
    }
}
