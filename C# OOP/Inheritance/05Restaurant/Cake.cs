using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public override double Grams { get { return 250; } }
        public override double Calories { get { return 1000; } }
        public override decimal Price { get { return CakePrice; } }
        public decimal CakePrice {get { return 5; } }

        public Cake(string name)
            : base(name, 0, 0, 0)
        {

        }
    }
}
