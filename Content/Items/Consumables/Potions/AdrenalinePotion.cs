using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using JourneysReborn.Content.Buffs;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
    public class AdrenalinePotion : ModItem
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
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.rare = ItemRarityID.LightRed;
            Item.value = Item.sellPrice(silver: 2);
            Item.buffType = ModContent.BuffType<Adrenaline>();
            Item.buffTime = 14400; 
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater, 1)			
				.AddIngredient(ItemID.PalladiumOre, 1)
                .AddIngredient(ItemID.Fireblossom, 1)
				.AddIngredient(ItemID.PixieDust, 1)
                .AddTile(TileID.Bottles)
                .Register();
        }
    }

    public class PalladiumPlayer : ModPlayer
    {
        // Храним значения, которые будут применяться в Update
        public float SpeedBonus;
        public int LifeRegenBonus;
        public int DefensePenalty;   // штраф (положительное число, будет вычитаться)

        public override void ResetEffects()
        {
            // Обнуляем каждый кадр, чтобы не накапливать
            SpeedBonus = 0f;
            LifeRegenBonus = 0;
            DefensePenalty = 0;
        }

        public override void PostUpdate()
        {
            // Применяем бонусы к игроку (вызывается каждый кадр после ResetEffects)
            Player.moveSpeed += SpeedBonus;
            Player.lifeRegen += LifeRegenBonus;
            Player.statDefense -= DefensePenalty; // штраф вычитается
        }
    }
}

