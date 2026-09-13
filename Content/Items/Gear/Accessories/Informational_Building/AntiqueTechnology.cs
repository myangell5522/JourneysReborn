using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class AntiqueTechnology : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.buyPrice(gold: 8);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.pickSpeed -= 0.25f;
            player.accOreFinder = true;
		}
		
		public override void UpdateInventory(Player player)
        {
            player.accOreFinder = true; 
        }

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.AncientChisel)
                .AddIngredient(ItemID.MetalDetector)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}