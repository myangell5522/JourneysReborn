using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Common;
using JourneysReborn.Content.Items.Gear.Armor;
using JourneysReborn.Content.Items.Misc.Blocks.Banners;
using JourneysReborn.Content.Projectiles.Hostile;

namespace JourneysReborn.Content.NPCs.Events.GoblinArmy
{
    public class GoblinMechanic : ModNPC
    {
        private int summonTimer;

        public override string Texture => "JourneysReborn/Content/NPCs/Events/Goblin Army/GoblinMechanic";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.GoblinWarrior];
            NPCID.Sets.BelongsToInvasionGoblinArmy[Type] = true;
            NPCID.Sets.InvasionSlotCount[Type] = 1;
            JRHelpers.SetDebuffImmunity(Type, BuffID.Confused);
            ItemID.Sets.KillsToBanner[ModContent.ItemType<GoblinMechanicBanner>()] = 25;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.GoblinWarrior);
            NPC.damage = 35;
            NPC.defense = 12;
            NPC.lifeMax = 200;
            NPC.knockBackResist = 0.35f;
            NPC.value = Item.sellPrice(silver: 20);
            NPC.rarity = 1;
            AnimationType = NPCID.GoblinWarrior;
            AIType = NPCID.GoblinWarrior;
            Banner = Type;
            BannerItem = ModContent.ItemType<GoblinMechanicBanner>();
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Invasions.Goblins,
                new FlavorTextBestiaryInfoElement("A goblin siege engineer. It deploys ballistae to pin down townsfolk and adventurers.")
            });
        }

        public override void PostAI()
        {
            summonTimer++;
            if (summonTimer < 480)
                return;

            summonTimer = 0;
            if (Main.netMode == NetmodeID.MultiplayerClient)
                return;
            if (NPC.CountNPCS(ModContent.NPCType<BattleBallista>()) >= 2)
                return;

            int x = (int)NPC.Center.X + NPC.direction * 48;
            int y = (int)NPC.Center.Y;
            int index = NPC.NewNPC(NPC.GetSource_FromAI(), x, y, ModContent.NPCType<BattleBallista>());
            if (index < Main.maxNPCs)
            {
                Main.npc[index].velocity.Y = -2f;
                Main.npc[index].netUpdate = true;
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechanicHelmet>(), 40));
        }
    }

    public class GoblinShaman : ModNPC
    {
        private int ritualTimer;

        public override string Texture => "JourneysReborn/Content/NPCs/Events/Goblin Army/GoblinShaman";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 3;
            NPCID.Sets.BelongsToInvasionGoblinArmy[Type] = true;
            NPCID.Sets.InvasionSlotCount[Type] = 1;
            NPCID.Sets.ImmuneToRegularBuffs[Type] = true;
            ItemID.Sets.KillsToBanner[ModContent.ItemType<GoblinShamanBanner>()] = 25;
        }

        public override void SetDefaults()
        {
            NPC.width = 28;
            NPC.height = 44;
            NPC.aiStyle = NPCAIStyleID.Fighter;
            NPC.damage = 25;
            NPC.defense = 10;
            NPC.lifeMax = 150;
            NPC.knockBackResist = 0.15f;
            NPC.value = Item.sellPrice(silver: 15);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.rarity = 1;
            Banner = Type;
            BannerItem = ModContent.ItemType<GoblinShamanBanner>();
            ritualTimer = Main.rand.Next(240, 421);
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Invasions.Goblins,
                new FlavorTextBestiaryInfoElement("A support caster that strips curses from fellow goblins or mends their wounds.")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.spriteDirection = NPC.direction;
            NPC.frameCounter++;
            if (NPC.frameCounter > 10)
            {
                NPC.frameCounter = 0;
                NPC.frame.Y += frameHeight;
                if (NPC.frame.Y >= frameHeight * 3)
                    NPC.frame.Y = 0;
            }
        }

        public override void PostAI()
        {
            ritualTimer--;
            if (ritualTimer > 0)
                return;

            ritualTimer = Main.rand.Next(240, 421);
            Rectangle area = new Rectangle((int)NPC.Center.X - 240, (int)NPC.Center.Y - 240, 480, 480);

            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC goblin = Main.npc[i];
                if (!goblin.active || goblin.friendly || goblin.whoAmI == NPC.whoAmI || !JRHelpers.IsGoblin(goblin))
                    continue;
                if (goblin.type == ModContent.NPCType<BattleBallista>())
                    continue;
                if (!area.Intersects(goblin.Hitbox))
                    continue;

                bool cleansed = false;
                for (int b = 0; b < goblin.buffType.Length; b++)
                {
                    int buff = goblin.buffType[b];
                    if (buff > 0 && Main.debuff[buff])
                    {
                        goblin.DelBuff(b);
                        b--;
                        cleansed = true;
                    }
                }

                if (!cleansed)
                {
                    int heal = (int)(goblin.lifeMax * 0.2f);
                    goblin.life = System.Math.Min(goblin.lifeMax, goblin.life + heal);
                    if (heal > 0)
                        goblin.HealEffect(heal, true);
                }

                for (int d = 0; d < 8; d++)
                    Dust.NewDust(goblin.position, goblin.width, goblin.height, DustID.GreenTorch, 0f, -1f, 150);
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinShamanMask>(), 40));
        }
    }

    public class BattleBallista : ModNPC
    {
        private int fireTimer;

        public override string Texture => $"Terraria/Images/Projectile_{ProjectileID.DD2BallistraTowerT1}";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 6;
            NPCID.Sets.BelongsToInvasionGoblinArmy[Type] = true;
            NPCID.Sets.InvasionSlotCount[Type] = 0;
            JRHelpers.SetDebuffImmunity(Type, BuffID.Poisoned, BuffID.Bleeding, BuffID.Confused);
        }

        public override void SetDefaults()
        {
            NPC.width = 40;
            NPC.height = 56;
            NPC.aiStyle = -1;
            NPC.damage = 10;
            NPC.defense = 25;
            NPC.lifeMax = 100;
            NPC.knockBackResist = 0f;
            NPC.noGravity = false;
            NPC.HitSound = SoundID.NPCHit4;
            NPC.DeathSound = SoundID.NPCDeath14;
            NPC.value = 0;
            NPC.rarity = 1;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Invasions.Goblins,
                new FlavorTextBestiaryInfoElement("A goblin-built ballista. It fires armor-piercing bolts at players and townsfolk.")
            });
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo) => 0f;

        public override void AI()
        {
            NPC.velocity.X *= 0.8f;
            NPC.TargetClosest();

            int target = FindTarget();
            if (target == -1)
                return;

            Vector2 aim = target >= 1000 ? Main.npc[target - 1000].Center : Main.player[target].Center;

            NPC.spriteDirection = aim.X < NPC.Center.X ? -1 : 1;
            fireTimer++;
            if (fireTimer < 160 || Main.netMode == NetmodeID.MultiplayerClient)
                return;

            fireTimer = 0;
            Vector2 velocity = aim - NPC.Center;
            if (velocity == Vector2.Zero)
                velocity = new Vector2(NPC.spriteDirection, 0f);
            velocity.Normalize();
            velocity *= 12f;
            SoundEngine.PlaySound(SoundID.DD2_BallistaTowerShot, NPC.Center);
            Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center - new Vector2(0, 8), velocity, ModContent.ProjectileType<BattleBallistaProjectile>(), 30, 2f, Main.myPlayer);
        }

        private int FindTarget()
        {
            float best = 800f;
            int result = -1;

            for (int i = 0; i < Main.maxPlayers; i++)
            {
                Player player = Main.player[i];
                if (!player.active || player.dead)
                    continue;
                float dist = Vector2.Distance(player.Center, NPC.Center);
                if (dist < best && Collision.CanHit(NPC.Center, 1, 1, player.Center, 1, 1))
                {
                    best = dist;
                    result = i;
                }
            }

            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (!npc.active || !npc.townNPC)
                    continue;
                float dist = Vector2.Distance(npc.Center, NPC.Center);
                if (dist < best && Collision.CanHit(NPC.Center, 1, 1, npc.Center, 1, 1))
                {
                    best = dist;
                    result = 1000 + i;
                }
            }

            return result;
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter > 8)
            {
                NPC.frameCounter = 0;
                NPC.frame.Y += frameHeight;
                if (NPC.frame.Y >= frameHeight * Main.npcFrameCount[Type])
                    NPC.frame.Y = 0;
            }
        }
    }
}
