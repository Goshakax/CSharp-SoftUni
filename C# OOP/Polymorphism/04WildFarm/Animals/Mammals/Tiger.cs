using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegin, string breed)
            : base(name, weight, livingRegin, breed)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Meat"
            };

            IncreasePerFood = 1;
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
