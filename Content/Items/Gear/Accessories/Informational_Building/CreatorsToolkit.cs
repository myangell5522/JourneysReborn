using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	[AutoloadEquip(EquipType.Back, EquipType.HandsOn, EquipType.HandsOff)]
	public class CreatorsToolkit : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
			Item.defense = 4;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.aggro -= 250;
			player.pickSpeed -= 0.25f;
            player.equippedAnyWallSpeedAcc = true;
			player.equippedAnyTileSpeedAcc = true;
			player.equippedAnyTileRangeAcc = true;
			player.autoPaint = true;
			player.treasureMagnet = true;
			player.accOreFinder = true;
			player.portableStoolInfo.SetStats(26, 26, 26);
            player.blockRange += 2;
            Player.tileRangeX += 1;
            Player.tileRangeY += 1;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.HandOfCreation)
				.AddIngredient(ItemID.MetalDetector)
				.AddIngredient(ItemID.Shackle)
				.AddIngredient(ItemID.SoulofNight, 10)
				.AddIngredient(ItemID.SoulofLight, 10)
				.AddIngredient(ItemID.SoulofFright, 4)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();

			CreateRecipe()
                .AddIngredient(ItemID.HandOfCreation)
				.AddIngredient(ItemID.MetalDetector)
				.AddIngredient(ItemID.Shackle)
				.AddIngredient(ItemID.SoulofNight, 10)
				.AddIngredient(ItemID.SoulofLight, 10)
				.AddIngredient(ItemID.SoulofMight, 4)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();

			CreateRecipe()
                .AddIngredient(ItemID.HandOfCreation)
				.AddIngredient(ItemID.MetalDetector)
				.AddIngredient(ItemID.Shackle)
				.AddIngredient(ItemID.SoulofNight, 10)
				.AddIngredient(ItemID.SoulofLight, 10)
				.AddIngredient(ItemID.SoulofSight, 4)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}