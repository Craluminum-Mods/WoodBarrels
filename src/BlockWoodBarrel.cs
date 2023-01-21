using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace WoodBarrels
{
    class BlockWoodBarrel : BlockBarrel
    {
        public override string GetHeldItemName(ItemStack itemStack) => GetName();
        public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos) => GetName();

        private string GetName()
        {
            var material = Variant["type"];
            var part = Lang.Get($"material-{material}");
            return string.Format($"{Lang.Get("block-barrel")} ({part})");
        }
    }
}