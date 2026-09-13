using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Fishing
{
	public class TreasureBobber : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 30;
			Item.value = Item.sellPrice(gold: 4);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccTreasureBobber>().treasureBobber = true;
            player.fishingSkill += 10;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.FishingBobber)
                .AddIngredient(ItemID.TreasureMagnet)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}

	public class AccTreasureBobber : ModPlayer
    {
        public bool treasureBobber;  
        public override void ResetEffects()
        {
            treasureBobber = false;
        }
    }

    public class TreasureBobberOreStack : GlobalItem
    {
        public override void CaughtFishStack(int type, ref int stack)
        {
            if(type == ItemID.CopperOre || type == ItemID.TinOre || type == ItemID.IronOre || type == ItemID.LeadOre ||
                type == ItemID.SilverOre || type == ItemID.TungstenOre || type == ItemID.GoldOre || type == ItemID.PlatinumOre) {
                    stack = Main.rand.Next(3, 7);
            };
            if(type == ItemID.CobaltOre || type == ItemID.PalladiumOre || type == ItemID.MythrilOre || type == ItemID.OrichalcumOre ||
                type == ItemID.AdamantiteOre || type == ItemID.TitaniumOre) {
                    stack = Main.rand.Next(2, 6);
            };
            if(type == ItemID.DemoniteOre || type == ItemID.CrimtaneOre) {
                stack = Main.rand.Next(2, 5);
            };
            if(type == ItemID.Obsidian) stack = Main.rand.Next(3, 6);
            if(type == ItemID.Hellstone) stack = Main.rand.Next(2, 5);
            if(type == ItemID.HoneyBlock) stack = Main.rand.Next(2, 6);
        }
    }
}