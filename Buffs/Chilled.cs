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
    class ChilledBuff : Buff
    {
        public ChilledBuff(int duration = 5000)
        {
            FullDuration = duration;

            Name = "Chilled";
            RawDescription = "Slows the unit's movement by {MoveSpeed:0;0}%, its attack speed by {AttackSpeed:0;0}%, but also provides {strength} strength. ";
            Icon = "horror-eerie-2";

            MoveSpeedPercentage = -190;
            AttackSpeedPercentage = -25;
            Strength = 5;
        }
    }
}
