using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Meat",
                "Seeds",
                "Fruit",
                "Vegetable"
            };
            IncreasePerFood = 0.35;
        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }
    }
}
