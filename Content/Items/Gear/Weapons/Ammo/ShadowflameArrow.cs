using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Misc.Materials;

namespace JourneysReborn.Content.Items.Gear.Weapons.Ammo
{
	public class ShadowflameArrow : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Shadowflame Arrow");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 2.15f;
			Item.value = 8;
			Item.rare = ItemRarityID.LightPurple;
			Item.shoot = ProjectileID.ShadowFlameArrow;
			Item.shootSpeed = 4.25f;
			Item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			CreateRecipe(50)
                .AddIngredient(ItemID.WoodenArrow, 50)
				.AddIngredient(ModContent.ItemType<Shadowflame>(), 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}