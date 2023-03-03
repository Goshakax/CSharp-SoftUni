using _04WildFarm.Animals;
using _04WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public abstract class Mammal : Animal, IMammal
    {

        protected Mammal(string name, double weight, string livingRegin)
            : base(name, weight)
        {
            LivingRegion = livingRegin;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
