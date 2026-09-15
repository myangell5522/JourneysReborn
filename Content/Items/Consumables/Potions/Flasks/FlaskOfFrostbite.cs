using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions.Flasks
{
	public class FlaskOfFrostbite : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 28;
			Item.maxStack = 9999;
            Item.value = Item.sellPrice(silver: 2);
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.consumable = true;
            Item.useTurn = true;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item3;
            Item.buffType = ModContent.BuffType<WeaponImbue_Frostbite>();
            Item.buffTime = Item.flaskTime;
		}

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.FrostCore)
                .AddTile(TileID.ImbuingStation)
                .Register();
        }
    }
}
