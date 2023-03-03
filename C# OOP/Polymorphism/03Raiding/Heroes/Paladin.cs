using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) 
            : base(name)
        {
            Power = 100;
        }

        public override string Name { get ; set ; }
        public override int Power { get ; set ; }

        public override string CastAbility()
        {
            return $"{nameof(Paladin)} - {Name} healed for {Power}";
        }
    }
}
