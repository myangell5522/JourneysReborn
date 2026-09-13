using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class SmartBracelet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 8);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.moveSpeed += 0.05f;
            player.accWatch = 3;
            player.accStopwatch = true;
		}
		
		public override void UpdateInventory(Player player) {
            player.accWatch = 3; 
			player.accStopwatch = true;
        }

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Aglet)
                .AddIngredient(ItemID.Stopwatch)
                .AddIngredient(ItemID.GoldWatch)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.Aglet)
                .AddIngredient(ItemID.Stopwatch)
                .AddIngredient(ItemID.PlatinumWatch)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}