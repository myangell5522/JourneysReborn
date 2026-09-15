using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Projectiles.Hostile
{
    public class BattleBallistaProjectile : ModProjectile
    {
        public override string Texture => $"Terraria/Images/Projectile_{ProjectileID.DD2BallistraProj}";

        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.hostile = true;
            Projectile.friendly = false;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 180;
            Projectile.tileCollide = true;
            Projectile.extraUpdates = 1;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
        }

        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation();
            if (Main.rand.NextBool(4))
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.WoodFurniture, 0f, 0f, 100, default, 0.8f);

            if (Projectile.localNPCImmunity != null)
            {
                for (int i = 0; i < Projectile.localNPCImmunity.Length; i++)
                {
                    if (Projectile.localNPCImmunity[i] > 0)
                        Projectile.localNPCImmunity[i]--;
                }
            }

            if (Main.netMode == NetmodeID.MultiplayerClient)
                return;

            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (!npc.active || !npc.townNPC || !Projectile.Hitbox.Intersects(npc.Hitbox))
                    continue;
                if (Projectile.localNPCImmunity != null && Projectile.localNPCImmunity[npc.whoAmI] > 0)
                    continue;

                npc.SimpleStrikeNPC(Projectile.damage, Projectile.direction, false, Projectile.knockBack);
                if (Projectile.localNPCImmunity != null)
                    Projectile.localNPCImmunity[npc.whoAmI] = Projectile.localNPCHitCooldown;

                Projectile.penetrate--;
                if (Projectile.penetrate <= 0)
                {
                    Projectile.Kill();
                    return;
                }
                break;
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            SoundEngine.PlaySound(SoundID.Dig, Projectile.Center);
            return true;
        }
    }
}
