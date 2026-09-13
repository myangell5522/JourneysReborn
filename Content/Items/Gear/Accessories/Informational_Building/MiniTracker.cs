using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Localization;
using JourneysReborn.Content.Items.Misc.Materials;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class MiniTracker : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 38;
			Item.height = 34;
			Item.value = Item.sellPrice(gold: 5);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccAnxietyRadar>().anxietyRadar = true;
            player.GetModPlayer<AccCardiograph>().cardiograph = true;
            player.GetModPlayer<AccLifeformDetector>().lifeformDetector = true;
			player.GetModPlayer<AccLuckyClover>().luckyCloverDisplay = true;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<LifeformDetectorCorruption>())
                .AddIngredient(ModContent.ItemType<AnxietyRadar>())
                .AddIngredient(ModContent.ItemType<Cardiograph>())
				.AddIngredient(ModContent.ItemType<LuckyClover>())
				.AddIngredient(ModContent.ItemType<LithiumSource>(), 3)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<LifeformDetectorCrimson>())
                .AddIngredient(ModContent.ItemType<AnxietyRadar>())
                .AddIngredient(ModContent.ItemType<Cardiograph>())
				.AddIngredient(ModContent.ItemType<LuckyClover>())
				.AddIngredient(ModContent.ItemType<LithiumSource>(), 3)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}