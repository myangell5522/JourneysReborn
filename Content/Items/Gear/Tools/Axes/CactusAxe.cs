using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Tools.Axes
{
	public class CactusAxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 3;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 38;
            Item.scale = 1f;
			Item.useTime = 22;
			Item.useAnimation = 32;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4.5f;
			Item.value = Item.buyPrice(silver: 16);
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.axe = 7;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if(Main.rand.NextBool(10)) {
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.JunglePlants);
			}
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Cactus, 12)
                .AddTile(TileID.WorkBenches)
                .Register();
		}
	}
}