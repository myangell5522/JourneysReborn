using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
	public class WeaponImbue_Shadowflame : ModBuff
	{
		public override void SetStaticDefaults() {
			BuffID.Sets.IsAFlaskBuff[Type] = true;
			Main.meleeBuff[Type] = true;
			Main.persistentBuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<WeaponImbue_ShadowflamePlayer>().shadowflameImbue = true;
			player.MeleeEnchantActive = true;
		}
	}

	public class WeaponImbue_ShadowflamePlayer :  ModPlayer
	{
		public bool shadowflameImbue = false;

		public override void ResetEffects() {
			shadowflameImbue = false;
		}

		public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone) {
			if(shadowflameImbue && item.DamageType.CountsAsClass<MeleeDamageClass>()) {
				target.AddBuff(BuffID.ShadowFlame, Main.rand.Next(240, 301));
			}
		}

		public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone) {
			if(shadowflameImbue && (proj.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[proj.type]) && !proj.noEnchantments) {
				target.AddBuff(BuffID.ShadowFlame, Main.rand.Next(240, 301));
			}
		}

		public override void MeleeEffects(Item item, Rectangle hitbox) {
			if(shadowflameImbue && item.DamageType.CountsAsClass<MeleeDamageClass>() && !item.noMelee && !item.noUseGraphic) {
				if (Main.rand.NextBool(5)) {
					Dust dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Shadowflame);
					dust.velocity *= 0.5f;
				}
			}
		}

		public override void EmitEnchantmentVisualsAt(Projectile projectile, Vector2 boxPosition, int boxWidth, int boxHeight) {
			if(shadowflameImbue && (projectile.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[projectile.type]) && !projectile.noEnchantments) {
				if (Main.rand.NextBool(5)) {
					Dust dust = Dust.NewDustDirect(boxPosition, boxWidth, boxHeight, DustID.Shadowflame);
					dust.velocity *= 0.5f;
				}
			}
		}
	}
}