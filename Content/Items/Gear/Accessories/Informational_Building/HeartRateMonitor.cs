using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Accessories.Defensive.Survivability;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class HeartRateMonitor : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 12);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.lifeRegen += 1;
			player.moveSpeed += 0.05f;
            player.accWatch = 3;
            player.accStopwatch = true;
			player.GetModPlayer<AccBandOfRecovery>().healBonus += 0.1f;
			player.GetModPlayer<AccCardiograph>().cardiograph = true;
		}
		
		public override void UpdateInventory(Player player) {
            player.accWatch = 3; 
			player.accStopwatch = true;
        }

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<SmartBracelet>())
				.AddIngredient(ModContent.ItemType<Cardiograph>())
                .AddIngredient(ItemID.BandofRegeneration)
				.AddIngredient(ModContent.ItemType<BandOfRecovery>())
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}