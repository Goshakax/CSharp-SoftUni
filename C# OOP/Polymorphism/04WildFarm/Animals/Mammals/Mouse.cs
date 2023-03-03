using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegin)
            : base(name, weight, livingRegin)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Vegetable",
                "Fruit"
            };

            IncreasePerFood = 0.1;
        }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
