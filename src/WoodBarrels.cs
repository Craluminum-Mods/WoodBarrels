using Vintagestory.API.Common;

[assembly: ModInfo("Wood Barrels",
    Authors = new[] { "Craluminum2413" })]

namespace WoodBarrels
{
    class WoodBarrels : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("WoodBarrels_BlockWoodBarrel", typeof(BlockWoodBarrel));
            api.World.Logger.Event("started 'Wood Barrels' mod");
        }
    }
}