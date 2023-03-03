using _04WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WildFarm.Animals
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodsCanEat = new HashSet<string>();
        }


        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public IReadOnlySet<string> FoodsCanEat { get; protected set; }

        public double IncreasePerFood { get; protected set; }

        public abstract void AskForFood();

        public void Eat(Food food)
        {
            if (this.FoodsCanEat.Contains(food.GetType().Name))
            {
                this.Weight += food.Quantity * this.IncreasePerFood;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }

    }
}
