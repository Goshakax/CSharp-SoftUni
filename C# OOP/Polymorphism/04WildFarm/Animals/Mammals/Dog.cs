using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegin) 
            : base(name, weight, livingRegin)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Meat"
            };
            IncreasePerFood = 0.4;
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
