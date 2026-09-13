using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class EbonstoneGolemHead : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 9999; // обычно не стакается в броне, но можно оставить 1
            Item.value = Item.buyPrice(0, 0, 50, 0);
            Item.rare = ItemRarityID.Blue;
            Item.defense = 0; // без защиты (чисто ванити)
            Item.headSlot = -1; // этот слот будет автоматически назначен благодаря AutoloadEquip, поэтому можно не ставить, но лучше оставить -1 или вообще не задавать.
        }
    }
}