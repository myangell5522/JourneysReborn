using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Misc.Materials;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
    [AutoloadEquip(EquipType.Face)]
	public class DangersenseLens : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.scale = 30f;
			Item.value = Item.buyPrice(gold: 20);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.dangerSense = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.IronBar, 8)
				.AddIngredient(ModContent.ItemType<LithiumSource>(), 3)
				.AddIngredient(ItemID.Topaz, 5)
				.AddIngredient(ItemID.BlackLens, 1)
                .AddIngredient(ItemID.Wire, 20)
                .AddTile(TileID.Anvils)
				.Register();
		}
	}
}