using Vintagestory.API.Common;

[assembly: ModInfo(name: "Wood Barrels", modID: "woodbarrels")]

namespace WoodBarrels;

public class Core : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        api.RegisterBlockBehaviorClass("WoodBarrels.Name", typeof(BlockBehaviorName));
        api.World.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }
}