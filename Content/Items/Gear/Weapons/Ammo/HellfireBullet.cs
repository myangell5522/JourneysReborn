using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Ammo;
using System;
using Terraria;
using Terraria.Audio;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Content.Items.Gear.Weapons.Ammo
{
	public class HellfireBullet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.damage = 8;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 3.5f;
			Item.value = 3;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<HellfireBulletProjectile>();
			Item.shootSpeed = 4.5f;
			Item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			CreateRecipe(70)
				.AddIngredient(ItemID.MusketBall, 70)
                .AddIngredient(ItemID.HellstoneBar, 1)
				.AddTile(TileID.Hellforge)
				.Register();
		}
	}

	public class HellfireBulletProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
		}

		public override void SetDefaults() {
			Projectile.width = 28;
			Projectile.height = 2;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.timeLeft = 600;
			Projectile.light = 0.5f;
			Projectile.ignoreWater = false;
			Projectile.tileCollide = true;
            Projectile.extraUpdates = 2;
            Projectile.penetrate = 2;
			
			AIType = ProjectileID.Bullet;
		}

        public override void AI()
		{
			Projectile.rotation = Projectile.velocity.ToRotation();
		}

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire3, Main.rand.Next(150, 271) + Projectile.penetrate * 30);
        }

        

		public override void OnKill(int timeLeft) {
			for(int i = 0; i < 3; i++) {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Lava);
                dust.scale = 0.8f;
            };
		}
	}
}