using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Microsoft.Xna.Framework;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
	public class FishingLuckPotion : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 34;
			Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 2);
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.consumable = true;
            Item.useTurn = true;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item3;
            Item.buffType = ModContent.BuffType<FishermansLuck>();
            Item.buffTime = 14400;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BottledWater) 
                .AddIngredient(ItemID.GoldenCarp)
                .AddIngredient(ItemID.Waterleaf)
                .AddIngredient(ItemID.WhitePearl)
				.AddIngredient(ItemID.BlackPearl)
				.AddIngredient(ItemID.PinkPearl)
                .AddTile(TileID.Bottles)
                .Register();
		}
	}
}