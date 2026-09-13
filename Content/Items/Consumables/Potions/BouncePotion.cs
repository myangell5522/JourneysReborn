using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
    public class BouncePotion : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
		}

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 30;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 2);
            Item.buffType = ModContent.BuffType<Buffs.Bounce>();
            Item.buffTime = 14400;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater, 1)
                .AddIngredient(ItemID.Blinkroot, 1)
                .AddIngredient(ItemID.PinkGel, 1)
                .AddTile(TileID.Bottles)
                .Register();
        }
    }
}