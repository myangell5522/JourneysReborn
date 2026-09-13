using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Microsoft.Xna.Framework;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
	public class SentryMasterPotion : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 30;
			Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 2);
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.consumable = true;
            Item.useTurn = true;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item3;
            Item.buffType = ModContent.BuffType<SentryMaster>();
            Item.buffTime = 28800;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Salmon, 1)
                .AddIngredient(ItemID.Shiverthorn, 1)
                .AddIngredient(ItemID.JungleSpores, 1)
                .AddIngredient(ItemID.Amber, 1)
                .AddTile(TileID.Bottles)
                .Register();
		}   
	}
}