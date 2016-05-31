using Shanism.Engine;
using Shanism.Engine.Entities;
using Shanism.Common.Game;

class Tree : Doodad
{
    public Tree()
    {
        var id = Rnd.Next(1, 3);
        ModelName = "units/tree/" + id;

        Scale = Rnd.NextDouble(2, 4);
        Name = "Tree";
    }
}