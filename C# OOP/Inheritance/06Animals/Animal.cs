using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Gender { get; set; }

        public virtual string AnimalType { get;}

        public Animal(string name, int age, string gender)
        {
                Age = age;
                Name = name;
                Gender = gender;      
        }

        public virtual string ProduceSound()
        {
            return "Sound";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(AnimalType);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(ProduceSound());

            return sb.ToString().TrimEnd();
        }

    }
}
