using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            StringBuilder output = new StringBuilder();

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string animalType = input;
                string[] animalArgs = Console.ReadLine().Split();
                string name = animalArgs[0];
                int age = int.Parse(animalArgs[1]);

                if (age<0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (animalType == "Cat")
                {
                    string gender = animalArgs[2];
                    Cat cat = new Cat(name, age, gender);
                    output.AppendLine(cat.ToString());
                }
                else if (animalType == "Frog")
                {
                    string gender = animalArgs[2];
                    Frog frog = new Frog(name, age, gender);
                    output.AppendLine(frog.ToString());
                }
                else if (animalType == "Dog")
                {
                    string gender = animalArgs[2];
                    Dog dog = new Dog(name, age, gender);
                    output.AppendLine(dog.ToString());
                }
                else if (animalType == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    output.AppendLine(tomcat.ToString());
                }
                else if (animalType == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    output.AppendLine(kitten.ToString());
                }

            }


            Console.WriteLine(output);
        }
    }
}
