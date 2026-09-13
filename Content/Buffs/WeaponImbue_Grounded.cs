using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
	public class WeaponImbue_Grounded : ModBuff
	{
		public override void SetStaticDefaults() {
			BuffID.Sets.IsAFlaskBuff[Type] = true;
			Main.meleeBuff[Type] = true;
			Main.persistentBuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<WeaponImbue_GroundedPlayer>().groundedImbue = true;
			player.MeleeEnchantActive = true;
		}
	}

	public class WeaponImbue_GroundedPlayer :  ModPlayer
	{
		public bool groundedImbue = false;

		public override void ResetEffects() {
			groundedImbue = false;
		}

		public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone) {
			if(groundedImbue && item.DamageType.CountsAsClass<MeleeDamageClass>()) {
				target.AddBuff(ModContent.BuffType<Grounded>(), 120);
			}
		}

		public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone) {
			if(groundedImbue && (proj.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[proj.type]) && !proj.noEnchantments) {
				target.AddBuff(ModContent.BuffType<Grounded>(), 120);
			}
		}

		public override void MeleeEffects(Item item, Rectangle hitbox) {
			if(groundedImbue && item.DamageType.CountsAsClass<MeleeDamageClass>() && !item.noMelee && !item.noUseGraphic) {
				if (Main.rand.NextBool(5)) {
					Dust dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Electric);
					dust.velocity *= 0.5f;
				}
			}
		}

		public override void EmitEnchantmentVisualsAt(Projectile projectile, Vector2 boxPosition, int boxWidth, int boxHeight) {
			if(groundedImbue && (projectile.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[projectile.type]) && !projectile.noEnchantments) {
				if (Main.rand.NextBool(5)) {
					Dust dust = Dust.NewDustDirect(boxPosition, boxWidth, boxHeight, DustID.Electric);
					dust.velocity *= 0.5f;
				}
			}
		}
	}
}