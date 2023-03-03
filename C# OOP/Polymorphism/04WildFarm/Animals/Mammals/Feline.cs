using _04WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, string livingRegin, string breed)
            : base(name, weight, livingRegin)
        {
            Breed = breed;  
        }

        public string Breed { get;private  set; }

        public override string ToString()
        {
            return $"{base.ToString()}{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
