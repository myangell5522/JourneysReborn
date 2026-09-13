using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords
{
	public class MandibleScissors : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			// DisplayName.SetDefault("Mandible Scissors");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.scale = 1.2f;
			Item.value = Item.buyPrice(silver: 50);
			Item.rare = ItemRarityID.Green;

			Item.useTime = 13;
			Item.useAnimation = 13;
			Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item1;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 18;
			Item.knockBack = 5.5f;
            Item.crit = 9;
			Item.ArmorPenetration = 5;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.AntlionClaw)
                .AddIngredient(ItemID.FossilOre, 12)
                .AddIngredient(ItemID.Amber, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
		}
	}
}