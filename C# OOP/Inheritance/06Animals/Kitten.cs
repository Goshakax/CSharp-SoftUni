using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : SmallCat
    {
        public override string AnimalType { get { return "Kitten"; } }
        public string KittenGender { get { return "Female"; } }
        public override string Gender {get { return KittenGender; } }

        public Kitten(string name, int age)
            : base(name, age)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
