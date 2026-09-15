using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class FlaskImbuePlayer : ModPlayer
    {
        public int ImbueDebuffType;
        public int ImbueDustType;

        public override void ResetEffects()
        {
            ImbueDebuffType = 0;
            ImbueDustType = 0;
        }

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (ImbueDebuffType > 0 && item.DamageType.CountsAsClass<MeleeDamageClass>())
                target.AddBuff(ImbueDebuffType, Main.rand.Next(240, 301));
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (ImbueDebuffType > 0 && (proj.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[proj.type]) && !proj.noEnchantments)
                target.AddBuff(ImbueDebuffType, Main.rand.Next(240, 301));
        }

        public override void MeleeEffects(Item item, Rectangle hitbox)
        {
            if (ImbueDebuffType <= 0 || ImbueDustType <= 0 || !item.DamageType.CountsAsClass<MeleeDamageClass>() || item.noMelee || item.noUseGraphic)
                return;

            if (Main.rand.NextBool(5))
            {
                Dust dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ImbueDustType);
                dust.velocity *= 0.5f;
            }
        }

        public override void EmitEnchantmentVisualsAt(Projectile projectile, Vector2 boxPosition, int boxWidth, int boxHeight)
        {
            if (ImbueDebuffType <= 0 || ImbueDustType <= 0 || !(projectile.DamageType.CountsAsClass<MeleeDamageClass>() || ProjectileID.Sets.IsAWhip[projectile.type]) || projectile.noEnchantments)
                return;

            if (Main.rand.NextBool(5))
            {
                Dust dust = Dust.NewDustDirect(boxPosition, boxWidth, boxHeight, ImbueDustType);
                dust.velocity *= 0.5f;
            }
        }
    }
}
