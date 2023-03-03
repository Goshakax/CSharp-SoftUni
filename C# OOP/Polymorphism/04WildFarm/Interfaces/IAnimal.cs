using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        public double IncreasePerFood { get; }
        int FoodEaten { get; }
        IReadOnlySet<string> FoodsCanEat { get; }
        void AskForFood();
        void Eat(Food food);
        


    }
}
