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
using Shanism.Common;

public class SpawnMonsterWaves : CustomScript
{
    const double InitialDelay = 5;  /* in seconds */
    const double WaveDelay = 5;  /* in seconds */

    int MonstersPerWave = 1;
    Vector spawnMonstersPoint = new Vector(20, 20);


    int currentLevel = 0;
    int monstersRemaining;


    public override async void OnGameStart()
    {
        await Task.Delay(TimeSpan.FromSeconds(InitialDelay));

        startNextWave();
    }

    void startNextWave()
    {
        currentLevel++;
        monstersRemaining = MonstersPerWave;

        for (int i = 0; i < MonstersPerWave; i++)
        {
            var m = new Monster(currentLevel) { Position = spawnMonstersPoint };
            m.Death += onMonsterDeath;
            Map.Add(m);
        }
    }

    async void onMonsterDeath(Shanism.Engine.Events.UnitDyingArgs obj)
    {
        monstersRemaining--;

        if (monstersRemaining <= 0)
        {
            await Task.Delay(TimeSpan.FromSeconds(WaveDelay));

            startNextWave();
        }
    }
}