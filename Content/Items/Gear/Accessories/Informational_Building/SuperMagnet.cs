using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	[AutoloadEquip(EquipType.Waist)]
	public class SuperMagnet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 40);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.manaMagnet = true;
            player.treasureMagnet = true;
            player.lifeMagnet = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.TreasureMagnet)
                .AddIngredient(ItemID.CelestialMagnet)
                .AddIngredient(ItemID.HeartreachPotion)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}