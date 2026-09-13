using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Ammo;

namespace JourneysReborn.Content.Items.Gear.Weapons.Ammo
{
	public class IcicleAmmo : ModItem
	{
		public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 14;
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 6f;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.White;
			Item.shoot = ModContent.ProjectileType<Icicle>();
			Item.ammo = Item.type;
		}

		public override void AddRecipes() {
			CreateRecipe(15)
                .AddIngredient(ItemID.IceBlock)
				.Register();
		}
	}

	public class Icicle : ModProjectile
	{

		public override void SetDefaults() {
			Projectile.width = 28;
			Projectile.height = 14;
			Projectile.scale = 0.75f;
			AIType = ProjectileID.SnowBallFriendly;
			
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.ignoreWater = false;
			Projectile.tileCollide = true;
			Projectile.timeLeft = 600;
			
			Projectile.penetrate = 3;
			Projectile.usesLocalNPCImmunity = true;
		}

		public override void AI()
		{
			Projectile.velocity.Y += 0.1f;
			Projectile.rotation = Projectile.velocity.ToRotation();
		}

		public override void OnKill(int timeLeft)
        {
            for(int i = 0; i < 3; i++) {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Ice);
                dust.scale = 0.8f;
            };
        }
	}
}