using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Defensive
{
	public class RustyHorseshoe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.buyPrice(gold: 10);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
			Item.defense = 2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = true;
            player.noFallDmg = true;
            player.buffImmune[BuffID.Burning] = true;
            player.luck += 0.05f;
        }

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.LuckyHorseshoe)
                .AddIngredient(ItemID.ObsidianShield)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
				
			CreateRecipe()
                .AddIngredient(ItemID.ObsidianHorseshoe)
                .AddIngredient(ItemID.CobaltShield)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();	
		}
	}
}