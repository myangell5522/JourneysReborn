using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class Toolkit : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 34;
			Item.height = 30;
			Item.value = Item.buyPrice(gold: 8);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.blockRange += 2;
            Player.tileRangeX += 1;
            Player.tileRangeY += 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Toolbelt);
            recipe.AddIngredient(ItemID.Toolbox);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }
    }
}