using _04WildFarm.Animals;
using _04WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public abstract class Bird : Animal, IBird
    {
        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize {get; private set;}

        public override string ToString()
        {
            return $"{base.ToString()}{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
