using Shanism.Common.Game;
using Shanism.Engine.Events;
using Shanism.Engine.Objects;
using Shanism.Engine.Entities;
using Shanism.Engine.Systems.Abilities;
using System.Threading.Tasks;
using System;

public class stone : Ability
{
    public stone()
    {
        // This code runs once the ability is created. 
        // Put initialization logic here. 
        TargetType = AbilityTargetType.PointTarget;
        Name = "Trow Stones";
        Description = "Dummy ability";

        Cooldown = 100;
        ManaCost = 0;
    }
    protected override void OnCast(AbilityCastArgs e)
    {
        var ownerPos = Owner.Position;
        var castPos = e.TargetLocation;

      
        var angle = ownerPos.AngleTo(castPos);


       // var c = new Bradva(Owner, angle + (Math.PI / 12));
        var p = new Bradva(Owner, angle);

       // Map.Add(c);
        Map.Add(p); 
        // This code is executed whenever the ability is cast. 
        // The variable `e` contains useful data about the event. 
    }

    protected override void OnLearned()
    {
        // This code is executed once when the ability is given Sto some unit. 
        // this.Owner refers to the unit that learned the ability. 
    }

    protected override void OnUpdate(int msElapsed)
    {
        // This code is executed every frame once the ability is learned by some unit. 
        // Be careful what you put here...
    }
}
