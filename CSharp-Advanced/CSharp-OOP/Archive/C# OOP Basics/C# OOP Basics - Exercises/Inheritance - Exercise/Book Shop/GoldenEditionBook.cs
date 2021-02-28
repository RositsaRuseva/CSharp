using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price)
            : base(title, author, price)
        {
        }

        public override double Price
        {
            get
            {
                return base.Price * 1.3;
            }
        }

    }
}
