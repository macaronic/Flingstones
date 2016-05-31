using Shanism.Common.Game;
using Shanism.Engine;
using Shanism.Engine.Objects;
using Shanism.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bradva : Projectile
{

    public Bradva(Unit owner, double angle)
        : base(owner)
    {
        Direction = angle;
        Speed = 25;
        Scale = 2.5;
        MaxRange = 15;
        Position = owner.Position;
        ModelName = $"objects/axe";
        DestroyOnCollision = true;

        Updated += onUpdate;
        OnUnitCollision += onUnitCollision;
    }

    void onUnitCollision(Projectile p, Unit u)
    {
        Owner.DamageUnit(u, DamageType.Magical, 500);
    }

    void onUpdate(Entity me, int msElapsed)
    {
        const double RotationsPerSecond = 1;
        const double RadiansPerSecond = (3.14 * Math.PI) * RotationsPerSecond;

        var secs = (double)msElapsed / 1000;
        var addedRotation = RadiansPerSecond * secs;

        Orientation += addedRotation;
    }


}
