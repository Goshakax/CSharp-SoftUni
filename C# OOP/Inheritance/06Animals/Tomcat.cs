using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : SmallCat
    {
        public override string AnimalType { get { return "Tomcat"; } }
        public string TomcatGender { get { return "Male"; } }
        public override string Gender { get { return TomcatGender; } }
        public Tomcat(string name, int age)
            : base (name, age)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
