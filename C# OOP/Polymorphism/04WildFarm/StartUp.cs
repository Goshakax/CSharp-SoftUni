using _04WildFarm;
using _04WildFarm.Animals;
using System.Reflection.Metadata;

string input = string.Empty;
List<Animal> animals = new List<Animal>();

while ((input = Console.ReadLine()) != "End")
{
    Animal animal = null;
    string[] animalTokens = input.Split();
    string type = animalTokens[0];
    string name = animalTokens[1];
    double weight = double.Parse(animalTokens[2]);

    if (type == "Cat")
    {
        string livingRegion = animalTokens[3];
        string breed = animalTokens[4];
        animal = new Cat(name, weight, livingRegion, breed);
    }
    else if (type == "Tiger")
    {
        string livingRegion = animalTokens[3];
        string breed = animalTokens[4];

        animal = new Tiger(name, weight, livingRegion, breed);
    }
    else if (type == "Mouse")
    {
        string livingRegion = animalTokens[3];
        animal = new Mouse(name, weight, livingRegion);
    }
    else if (type == "Dog")
    {
        string livingRegion = animalTokens[3];
        animal = new Dog(name, weight, livingRegion);
    }
    else if (type == "Hen")
    {
        double wingSize = double.Parse(animalTokens[3]);
        animal = new Hen(name, weight, wingSize);
    }
    else if (type == "Owl")
    {
        double wingSize = double.Parse(animalTokens[3]);
        animal = new Owl(name, weight, wingSize);
    }




    Food food = null;
    string[] foodTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string foodType = foodTokens[0];
    int quantity = int.Parse(foodTokens[1]);


    if (foodType == "Vegetable")
    {
        food = new Vegetable(quantity);
    }
    else if (foodType == "Fruit")
    {
        food = new Fruit(quantity);
    }
    else if (foodType == "Meat")
    {
        food = new Meat(quantity);
    }
    else if (foodType == "Seeds")
    {
        food = new Seeds(quantity);
    }
   

    animal.AskForFood();
    animal.Eat(food);

    animals.Add(animal);

}


foreach (var currAnimal in animals)
{
    Console.WriteLine(currAnimal.ToString());
}





