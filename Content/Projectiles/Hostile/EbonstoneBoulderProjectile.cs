using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Projectiles.Hostile
{
    public abstract class BiomeGolemRock : ModProjectile
    {
        public abstract int InflictedBuff { get; }
        public abstract int BuffTime { get; }

        public override void SetStaticDefaults()
        {
            Main.projFrames[Type] = 6;
        }

        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.hostile = true;
            Projectile.friendly = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 300;
            Projectile.tileCollide = true;
        }

        public override void AI()
        {
            if (++Projectile.frameCounter >= 5)
            {
                Projectile.frameCounter = 0;
                Projectile.frame = (Projectile.frame + 1) % Main.projFrames[Type];
            }

            Projectile.velocity.Y += 0.2f;
            if (Projectile.velocity.Y > 16f)
                Projectile.velocity.Y = 16f;
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            target.AddBuff(InflictedBuff, BuffTime);
        }
    }

    public abstract class BiomeGolemBoulder : ModProjectile
    {
        public abstract int MiniType { get; }
        public abstract int InflictedBuff { get; }
        public abstract int BuffTime { get; }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.Boulder);
            Projectile.width = 30;
            Projectile.height = 30;
            Projectile.aiStyle = -1;
            Projectile.hostile = true;
        }

        public override void AI()
        {
            Projectile.rotation += Projectile.velocity.X * 0.02f;
            Projectile.velocity.Y += 0.3f;
            if (Projectile.velocity.Y > 16f)
                Projectile.velocity.Y = 16f;

            if (Projectile.velocity.Y == 0f)
            {
                Projectile.velocity.X *= 0.98f;
                if (Projectile.velocity.X > -0.1f && Projectile.velocity.X < 0.1f)
                    Projectile.velocity.X = 0f;
            }
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            target.AddBuff(InflictedBuff, BuffTime);
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (Main.getGoodWorld && MiniType > 0 && Main.netMode != NetmodeID.MultiplayerClient)
            {
                int count = Main.rand.Next(2, 5);
                for (int i = 0; i < count; i++)
                {
                    Vector2 pos = Projectile.position + new Vector2(Main.rand.Next(-10, 10), Main.rand.Next(-10, 10));
                    Vector2 vel = new Vector2(Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(-2f, -1f));
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), pos, vel, MiniType, (int)(Projectile.damage * 0.75f), Projectile.knockBack * 0.75f, Projectile.owner);
                }
            }

            return true;
        }
    }

    public class EbonstoneRock : BiomeGolemRock
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/EbonstoneRock_Projectile";
        public override int InflictedBuff => BuffID.CursedInferno;
        public override int BuffTime => 420;
    }

    public class CrimstoneRock : BiomeGolemRock
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/CrimstoneRock_Projectile";
        public override int InflictedBuff => BuffID.Ichor;
        public override int BuffTime => 600;
    }

    public class PearlstoneRock : BiomeGolemRock
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/PearlstoneRock_Projectile";
        public override int InflictedBuff => BuffID.Confused;
        public override int BuffTime => 600;
    }

    public class EbonstoneBoulderProjectile : BiomeGolemBoulder
    {
        public override int MiniType => ModContent.ProjectileType<EbonstoneBoulderProjectileFTW>();
        public override int InflictedBuff => BuffID.CursedInferno;
        public override int BuffTime => 420;
    }

    public class EbonstoneBoulderProjectileFTW : BiomeGolemBoulder
    {
        public override int MiniType => 0;
        public override int InflictedBuff => BuffID.CursedInferno;
        public override int BuffTime => 420;

        public override void SetDefaults()
        {
            base.SetDefaults();
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.scale = 0.6f;
            Projectile.timeLeft = 300;
        }
    }

    public class CrimstoneBoulderProjectile : BiomeGolemBoulder
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/CrimstoneBoulder_Projectile";
        public override int MiniType => ModContent.ProjectileType<CrimstoneBoulderProjectileFTW>();
        public override int InflictedBuff => BuffID.Ichor;
        public override int BuffTime => 600;
    }

    public class CrimstoneBoulderProjectileFTW : BiomeGolemBoulder
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/CrimstoneBoulder_ProjectileFTW";
        public override int MiniType => 0;
        public override int InflictedBuff => BuffID.Ichor;
        public override int BuffTime => 600;

        public override void SetDefaults()
        {
            base.SetDefaults();
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.scale = 0.6f;
            Projectile.timeLeft = 300;
        }
    }

    public class PearlstoneBoulderProjectile : BiomeGolemBoulder
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/PearlstoneBoulder_Projectile";
        public override int MiniType => ModContent.ProjectileType<PearlstoneBoulderProjectileFTW>();
        public override int InflictedBuff => BuffID.Confused;
        public override int BuffTime => 600;
    }

    public class PearlstoneBoulderProjectileFTW : BiomeGolemBoulder
    {
        public override string Texture => "JourneysReborn/Content/Projectiles/Hostile/PearlstoneBoulder_ProjectileFTW";
        public override int MiniType => 0;
        public override int InflictedBuff => BuffID.Confused;
        public override int BuffTime => 600;

        public override void SetDefaults()
        {
            base.SetDefaults();
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.scale = 0.6f;
            Projectile.timeLeft = 300;
        }
    }
}
