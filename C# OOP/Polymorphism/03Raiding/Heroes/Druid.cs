using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name ) 
            : base(name)
        {
            Power = 80;
        }

        public override string Name { get; set; }
        public override int Power { get; set; }

        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {Name} healed for {Power}";
        }
    }
}
