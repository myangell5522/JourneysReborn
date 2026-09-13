using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Misc.Materials;
using JourneysReborn.Content.Items.Gear.Weapons.Ammo;
using Terraria;

namespace JourneysReborn.Content.Items.Gear.Weapons.Ammo
{
	public class ShadowflameBullet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Shadowflame Bullet");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.damage = 9;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 3.15f;
			Item.value = 6;
			Item.rare = ItemRarityID.LightPurple;
			Item.shoot = ModContent.ProjectileType<ShadowflameBulletProjectile>();
			Item.shootSpeed = 5.75f;
			Item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			CreateRecipe(50)
                .AddIngredient(ItemID.MusketBall, 50)
				.AddIngredient(ModContent.ItemType<Shadowflame>(), 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class ShadowflameBulletProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
		}

		public override void SetDefaults() {
			Projectile.width = 20;
			Projectile.height = 2;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.penetrate = 1;
			Projectile.timeLeft = 600;
			Projectile.light = 0.25f;
			Projectile.ignoreWater = false;
			Projectile.tileCollide = true;
			Projectile.penetrate = -1;
			Projectile.extraUpdates = 3;
			
			AIType = ProjectileID.Bullet;
		}

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.ShadowFlame, 120, true);
        }

        public override void AI()
		{
			Projectile.rotation = Projectile.velocity.ToRotation();
		}

		public override void OnKill(int timeLeft)
        {
            for(int i = 0; i < 3; i++) {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Shadowflame);
                dust.scale = 0.8f;
            };
        }
	}
}