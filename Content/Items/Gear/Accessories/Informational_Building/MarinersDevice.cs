using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Accessories.Informational_Building;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building

{
	public class MarinersDevice : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 34;
			Item.value = Item.sellPrice(gold: 5);
			Item.rare = ItemRarityID.Pink;
			Item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.accFishFinder = true;
			player.accWeatherRadio = true;
			player.accCalendar = true;
            player.GetModPlayer<AccFishingSchedule>().fishingSchedule = true;
		}
		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.FishFinder)
                .AddIngredient(ModContent.ItemType<FishingSchedule>())
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}