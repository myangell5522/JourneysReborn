using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Microsoft.Xna.Framework;
using JourneysReborn.Content.Items.Misc.Materials;

namespace JourneysReborn.Content.Items.Consumables.Potions
{
	public class PotionOfRebirth : ModItem
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
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item3;
		}

        public override bool CanUseItem(Player player)
        {
            return player.lastDeathPostion != Vector2.Zero;
        }

        public override bool ConsumeItem(Player player)
        {
            return true;
        }   

        public override bool? UseItem(Player player)
        {
            player.Teleport(player.lastDeathPostion, 0, 0);
            return true;
        }

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Deathweed)
                .AddIngredient(ModContent.ItemType<GhostMatter>())
                .AddIngredient(ItemID.DemoniteOre)
                .AddTile(TileID.Bottles)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Deathweed)
                .AddIngredient(ModContent.ItemType<GhostMatter>())
                .AddIngredient(ItemID.CrimtaneOre)
                .AddTile(TileID.Bottles)
                .Register();
		}
    
	}
}