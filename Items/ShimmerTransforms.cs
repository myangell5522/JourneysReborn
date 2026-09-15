using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Items
{
    public class ShimmerTransforms : ModSystem
    {
        public override void PostSetupContent()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.HelFire] = ItemID.Cascade;
            ItemID.Sets.ShimmerTransformToItem[ItemID.ZapinatorOrange] = ItemID.ZapinatorGray;
            ItemID.Sets.ShimmerTransformToItem[ItemID.ShadowKey] = ItemID.ShadowChest;
            ItemID.Sets.ShimmerTransformToItem[ItemID.GoldenKey] = ItemID.GoldChest;
            ItemID.Sets.ShimmerTransformToItem[ItemID.RedHusk] = ItemID.VioletHusk;
            ItemID.Sets.ShimmerTransformToItem[ItemID.VioletHusk] = ItemID.CyanHusk;
            ItemID.Sets.ShimmerTransformToItem[ItemID.CyanHusk] = ItemID.RedHusk;
        }
    }
}
