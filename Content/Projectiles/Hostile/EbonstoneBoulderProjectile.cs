using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Content.Projectiles.Hostile
{
    // Основной валун (большой)
    public class EbonstoneBoulderProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.Boulder);
            Projectile.width = 30;
            Projectile.height = 30;
            Projectile.aiStyle = -1;
            Projectile.ai[0] = 0; // 0 – обычный валун
        }

        public override void AI()
        {
            Projectile.rotation += Projectile.velocity.X * 0.02f;
            Projectile.velocity.Y += 0.3f;
            if (Projectile.velocity.Y > 16f) Projectile.velocity.Y = 16f;
            if (Projectile.velocity.Y == 0f)
            {
                Projectile.velocity.X *= 0.98f;
                if (Projectile.velocity.X > -0.1f && Projectile.velocity.X < 0.1f)
                    Projectile.velocity.X = 0f;
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            // В ForTheWorthy большие валуны разбиваются на мини-версии
            if (Main.getGoodWorld)
            {
                int count = Main.rand.Next(2, 5); // 2–4 шт.
                for (int i = 0; i < count; i++)
                {
                    Vector2 pos = Projectile.position + new Vector2(Main.rand.Next(-10, 10), Main.rand.Next(-10, 10));
                    Vector2 vel = new Vector2(Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(-2f, -1f));

                    Projectile.NewProjectile(
                        Projectile.GetSource_FromThis(),
                        pos,
                        vel,
                        ModContent.ProjectileType<EbonstoneBoulderProjectileFTW>(), // мини-снаряд
                        (int)(Projectile.damage * 0.75f),
                        Projectile.knockBack * 0.75f,
                        Projectile.owner
                    );
                }
            }
            return true; // уничтожаем большой валун
        }
    }

    // Мини-валун для FTW (использует текстуру EbonstoneBoulderProjectileFTW.png)
    public class EbonstoneBoulderProjectileFTW : ModProjectile
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.Boulder);
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.scale = 0.6f;
            Projectile.aiStyle = -1;
            Projectile.timeLeft = 300;
        }

        public override void AI()
        {
            // Тот же AI, что и у большого валуна
            Projectile.rotation += Projectile.velocity.X * 0.02f;
            Projectile.velocity.Y += 0.3f;
            if (Projectile.velocity.Y > 16f) Projectile.velocity.Y = 16f;
            if (Projectile.velocity.Y == 0f)
            {
                Projectile.velocity.X *= 0.98f;
                if (Projectile.velocity.X > -0.1f && Projectile.velocity.X < 0.1f)
                    Projectile.velocity.X = 0f;
            }
        }
    }
}