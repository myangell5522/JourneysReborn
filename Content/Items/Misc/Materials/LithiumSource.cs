using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using JourneysReborn.Content.Items.Misc.Ores;

namespace JourneysReborn.Content.Items.Misc.Materials
{
	public class LithiumSource : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 32;
			Item.maxStack = 9999;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 5);
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<LithiumBar>(), 3)
                .AddTile(TileID.Anvils)
                .Register();
		}
	}
}