using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;
using JourneysReborn.Content.Items.Gear.Weapons.Ammo;
using Terraria.Audio;
using System;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Content.Items.Gear.Weapons.Ammo
{
	public class JaggedArrow : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.damage = 9;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 14;
			Item.height = 38;
			Item.maxStack = 9999;
			Item.consumable = true;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(copper: 15);
			Item.rare = ItemRarityID.Blue;
			Item.shoot = ModContent.ProjectileType<JaggedArrowProj>();
			Item.shootSpeed = 4.5f;
			Item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			CreateRecipe(30)
                .AddIngredient(ItemID.AntlionMandible, 1)
				.AddIngredient(ItemID.FossilOre, 1)
				.Register();

            CreateRecipe(300)
                .AddIngredient(ItemID.AntlionClaw, 1)
				.AddIngredient(ItemID.FossilOre, 5)
				.Register();

            CreateRecipe(400)
                .AddIngredient(ModContent.ItemType<MandibleScissors>(), 1)
				.AddIngredient(ItemID.FossilOre, 5)
				.Register();
		}
	}

	public class JaggedArrowProj : ModProjectile
	{
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			Projectile.width = 38;
			Projectile.height = 14;
			Projectile.scale = 1f;
			AIType = ProjectileID.WoodenArrowFriendly;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.ignoreWater = false;
			Projectile.tileCollide = true;
			Projectile.timeLeft = 600;
            Projectile.penetrate = 2;
            Projectile.ArmorPenetration = 5;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
			SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
			if(Math.Abs(Projectile.velocity.X - oldVelocity.X) > float.Epsilon) {
				Projectile.velocity.X = -oldVelocity.X;
			};
			if(Math.Abs(Projectile.velocity.Y - oldVelocity.Y) > float.Epsilon) {
				 Projectile.velocity.Y = -oldVelocity.Y;
			};
            if(Projectile.ai[1] < 2) {
                Projectile.damage += 3;
                Projectile.ai[1] += 1;
            };
            if(Projectile.ai[2] >= 1) {
                return true;
            };
            Projectile.ai[2] += 1;
            return false;
        }

        public override void AI()
		{
			Projectile.rotation = Projectile.velocity.ToRotation();
		}

        public override void OnKill(int timeLeft)
        {
            for(int i = 0; i < 3; i++) {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.Sand);
                dust.scale = 0.8f;
            };
        }
	}
}