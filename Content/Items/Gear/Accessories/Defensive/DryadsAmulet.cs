using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Defensive
{
	[AutoloadEquip(EquipType.Neck)]
	public class DryadsAmulet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Dryad's Amulet");
			// Tooltip.SetDefault("Re-adresses damage from town NPCs to you");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 32;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccDryadsAmulet>().dryadsAmulet = true;
		}
	}

	public class AccDryadsAmulet : ModPlayer
    {
        public bool dryadsAmulet;
        public override void ResetEffects()
        {
            dryadsAmulet = false;
        }
    }
}