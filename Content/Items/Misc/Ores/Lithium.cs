using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace JourneysReborn.Content.Items.Misc.Ores
{
    public class LithiumOre : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 100;
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
			ItemID.Sets.OreDropsFromSlime[Type] = (1, 4);
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<LithiumOre_Tile>());
			Item.width = 16;
			Item.height = 16;
			Item.value = Item.sellPrice(silver: 1, copper: 20);
		}
	}

    public class LithiumOre_Tile : ModTile
	{
		public override void SetStaticDefaults() {
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 235;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			LocalizedText name = CreateMapEntryName();
			AddMapEntry(new Color(31, 206, 203), Language.GetText("Mods.BalanceMod.TileMapDisplayName.LithiumOre"));

			DustType = 84;
			HitSound = SoundID.Tink;
            MineResist = 2.5f;
            MinPick = 55;
		}
    }

	public class LithiumBar : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
		}
		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999; 
			Item.value = Item.sellPrice(silver: 8);
            Item.rare = ItemRarityID.White;
			Item.DefaultToPlaceableTile(ModContent.TileType<LithiumBar_Tile>());
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<LithiumOre>(), 4)
                .AddTile(TileID.Furnaces)
                .Register();
		}
	}

	public class LithiumBar_Tile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileShine[Type] = 1100;
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(48, 213, 200), Language.GetText("MapObject.MetalBar"));
		}
	}
}