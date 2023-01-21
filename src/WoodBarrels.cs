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
            api.World.Logger.Event("started 'Wood Barrels' mod");
        }
    }
}