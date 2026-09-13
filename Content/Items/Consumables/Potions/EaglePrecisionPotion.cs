using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Microsoft.Xna.Framework;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
	public class EaglePrecisionPotion : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 32;
			Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 2);
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.consumable = true;
            Item.useTurn = true;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item3;
            Item.buffType = ModContent.BuffType<EaglePrecision>();
            Item.buffTime = 21600;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.RockLobster)
                .AddIngredient(ItemID.Blinkroot)
                .AddTile(TileID.Bottles)
                .Register();
		}
    
	}
}