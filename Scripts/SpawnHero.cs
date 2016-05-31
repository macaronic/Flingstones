using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shanism.Engine;
using Shanism.Engine.Systems;
using Shanism.Engine.Entities;
using Shanism.Common.Game;
using Shanism.Engine.Systems.Abilities;
using System.Threading;
using Shanism.Engine.Objects.Buffs;
using Shanism.Common;
using DefaultScenario.Units;
using Shanism.Engine.Objects;

public class SpawnHeroes : CustomScript
{
    public override void OnHeroSpawned(Hero hero)
    {
        var imbaBuff = new Buff { LifeRegen = 5000, RawDescription = "Makes you imba, giving ya {LifeRegen} life/sec. " };
        hero.Buffs.Apply(null, imbaBuff);
    }

    public override void OnPlayerJoined(Player p)
    {
        if (!p.HasHero)
        {
            var h = new Albimon(p)
            {
                Position = new Vector(10, 10),
                Name = p.Name ?? "?!"
            };

            

            Map.Add(h);
            p.SetMainHero(h);
        }

    }

    
}