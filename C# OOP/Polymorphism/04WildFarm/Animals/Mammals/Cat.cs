using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegin, string breed)
            : base(name, weight, livingRegin, breed)
        {
            FoodsCanEat = new HashSet<string>
            {
                "Meat",
                "Vegetable"
            };

            IncreasePerFood = 0.3;


        }

   

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        
    }
}
