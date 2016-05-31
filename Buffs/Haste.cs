using Shanism.Engine.Objects;
using Shanism.Engine.Objects.Buffs;
using Shanism.Common.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultScenario.Buffs
{
    public class Haste : Buff
    {
        public Haste(int duration = 5000)
        {
            FullDuration = duration;

            Name = "Haste";
            RawDescription = "Increases the unit's movement speed by {MoveSpeed:0;0}% and its attack speed by {AttackSpeedPercentage:0;0}%. ";
            Icon = "enchant-orange-3";

            MoveSpeedPercentage = 400;
            AttackSpeedPercentage = 25;

        }
    }
}
