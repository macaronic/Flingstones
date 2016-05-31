using Shanism.Engine;
using Shanism.Engine.Entities;
using Shanism.Common.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultScenario.Units
{
    class Albimon : Hero
    {
        public Albimon(Player owner)
            : base(owner)
        {
            Name = "Albimon";
            ModelName = "units/hero";
            Scale = 4;
            Abilities.Add(new stone());

        }
    }
}
