using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Common;

namespace JourneysReborn.Content.NPCs
{
    public abstract class BiomeGolem : ModNPC
    {
        private const int AttackLength = 100;
        private const int AttackWindow = 32;

        public abstract int BlockItem { get; }
        public abstract int HeadItem { get; }
        public abstract int BannerItemType { get; }
        public abstract int RockProjectile { get; }
        public abstract int BoulderProjectile { get; }
        public abstract int SpawnTile { get; }
        public abstract int RockDamage { get; }
        public abstract int BoulderDamage { get; }
        public abstract IBestiaryInfoElement[] BestiaryElements { get; }

        public override void SetStaticDefaults()
        {
            // Sheet is 60x1554: 21 frames of 74px, same layout as the Rock Golem.
            // 37 cuts every pose in half.
            Main.npcFrameCount[Type] = 21;
            JRHelpers.SetDebuffImmunity(Type,
                BuffID.Poisoned, BuffID.Bleeding, BuffID.Confused,
                BuffID.OnFire, BuffID.OnFire3);
        }

        public override void SetDefaults()
        {
            NPC.width = 40;
            NPC.height = 56;
            NPC.aiStyle = NPCAIStyleID.Fighter;
            NPC.damage = 95;
            NPC.defense = 40;
            NPC.lifeMax = 1100;
            NPC.knockBackResist = 0.05f;
            NPC.value = Item.sellPrice(gold: 3);
            NPC.HitSound = SoundID.NPCHit41;
            NPC.DeathSound = SoundID.NPCDeath43;
            NPC.rarity = 2;
            Banner = Type;
            BannerItem = BannerItemType;
            AnimationType = NPCID.RockGolem;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(BestiaryElements);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.hardMode || !spawnInfo.Player.ZoneRockLayerHeight)
                return 0f;
            if (spawnInfo.SpawnTileType != SpawnTile)
                return 0f;
            if (!InCorrectBiome(spawnInfo))
                return 0f;
            return 0.05f;
        }

        protected abstract bool InCorrectBiome(NPCSpawnInfo spawnInfo);

        public override void PostAI()
        {
            // Same ai[2] windup the Rock Golem sheet was drawn for: frames 0-7 walk, 10-20 throw.
            NPC.TargetClosest(NPC.ai[2] > 0f);
            Player player = Main.player[NPC.target];
            bool inRange = player.active && !player.dead && Vector2.Distance(player.Center, NPC.Center) < 320f;
            bool canHit = inRange && Collision.CanHit(NPC.position, NPC.width, NPC.height, player.position, player.width, player.height);

            if (NPC.ai[2] == 0f)
            {
                if (canHit)
                {
                    NPC.ai[2] = AttackLength;
                    NPC.velocity.X = NPC.direction * 0.01f;
                    NPC.netUpdate = true;
                }
                return;
            }

            if (NPC.ai[2] < AttackLength)
            {
                NPC.ai[2] += 1f;
                NPC.velocity.X *= 0.9f;
                if (System.Math.Abs(NPC.velocity.X) < 0.001f)
                    NPC.velocity.X = 0f;
                if (System.Math.Abs(NPC.velocity.Y) > 1f)
                    NPC.ai[2] = 0f;

                if (NPC.ai[2] == AttackLength - AttackWindow / 2f && Main.netMode != NetmodeID.MultiplayerClient && canHit && !player.Hitbox.Intersects(NPC.Hitbox))
                {
                    Vector2 direction = player.Center - NPC.Center;
                    if (direction.LengthSquared() < 1f)
                        direction = new Vector2(NPC.direction, -0.25f);
                    direction.Normalize();
                    direction *= 10f;
                    direction.Y -= 2.5f;
                    Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center, direction, RockProjectile, RockDamage, 4f, Main.myPlayer);
                }
                return;
            }

            if (NPC.velocity.Y == 0f && canHit)
            {
                NPC.ai[2] = AttackLength - AttackWindow;
                NPC.netUpdate = true;
            }
        }

        public override void HitEffect(NPC.HitInfo hit)
        {
            if (NPC.life > 0)
                return;

            for (int i = 0; i < 16; i++)
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Stone, hit.HitDirection, -1f);
        }

        public override void OnKill()
        {
            if (Main.getGoodWorld && Main.netMode != NetmodeID.MultiplayerClient)
            {
                Vector2 velocity = new Vector2(NPC.direction * 3f, -2f);
                Projectile.NewProjectile(NPC.GetSource_Death(), NPC.Center, velocity, BoulderProjectile, BoulderDamage, 8f, Main.myPlayer);
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(BlockItem, 1, 10, 20));
            npcLoot.Add(ItemDropRule.Common(HeadItem, 3));
        }
    }
}
