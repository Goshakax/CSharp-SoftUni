using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Meat"
            };
            IncreasePerFood = 0.25;
        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
