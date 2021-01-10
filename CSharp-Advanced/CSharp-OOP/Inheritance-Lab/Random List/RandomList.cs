using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;
       

        public RandomList(IEnumerable<string> phrases)
            :base(phrases)
        {
            rnd = new Random();

        }

        public string RandomString()
        {
            string result = string.Empty;
            int index = rnd.Next(0, this.Count);
            result = this[index];
            this.RemoveAt(index);


            return result;
        }
    }
}
