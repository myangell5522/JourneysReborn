using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;
using JourneysReborn.Content.NPCs.Biomes.Mushrooms;
using JourneysReborn.Content.NPCs.Events.BloodMoon;
using JourneysReborn.Content.NPCs.Events.GoblinArmy;
using JourneysReborn.Content.NPCs.Friendly.Critters;

namespace JourneysReborn.NPCs
{
    public class TZSpawnsAndLoot : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Invasion && Main.invasionType == InvasionID.GoblinArmy)
            {
                if (NPC.downedBoss3 && NPC.CountNPCS(ModContent.NPCType<GoblinMechanic>()) < 2)
                    pool[ModContent.NPCType<GoblinMechanic>()] = 0.28f;

                if (NPC.downedQueenBee && NPC.CountNPCS(ModContent.NPCType<GoblinShaman>()) < 2)
                    pool[ModContent.NPCType<GoblinShaman>()] = 0.28f;
            }

            if (Main.expertMode)
            {
                TryReplaceSpawn(pool, NPCID.BloodZombie, ModContent.NPCType<BloodZombieArmed>(), 0.25f);
                TryReplaceSpawn(pool, NPCID.ZombieMushroom, ModContent.NPCType<SporeZombieArmed>(), 0.25f);
                TryReplaceSpawn(pool, NPCID.ZombieMushroomHat, ModContent.NPCType<SporeZombieArmed>(), 0.25f);
            }
        }

        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            if (Main.netMode == NetmodeID.MultiplayerClient)
                return;
            if (npc.SpawnedFromStatue || npc.ModNPC is GoldCritter)
                return;

            TryGold(npc, NPCID.Duck, NPCID.Duck2, ModContent.NPCType<GoldDuck>());
            TryGold(npc, NPCID.Penguin, NPCID.PenguinBlack, ModContent.NPCType<GoldPenguin>());
            TryGold(npc, NPCID.Owl, -1, ModContent.NPCType<GoldOwl>());
            TryGold(npc, NPCID.Seagull, NPCID.Seagull2, ModContent.NPCType<GoldSeagull>());
            TryGold(npc, NPCID.Toucan, -1, ModContent.NPCType<GoldToucan>());
            TryGold(npc, NPCID.ScarletMacaw, NPCID.BlueMacaw, ModContent.NPCType<GoldMacaw>());
            TryGold(npc, NPCID.YellowCockatiel, NPCID.GrayCockatiel, ModContent.NPCType<GoldCockatiel>());
            TryGold(npc, NPCID.Scorpion, NPCID.ScorpionBlack, ModContent.NPCType<GoldScorpion>());
            TryGold(npc, NPCID.Turtle, NPCID.SeaTurtle, ModContent.NPCType<GoldTurtle>());
        }

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BloodZombie)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodZombieArm>(), 250));

            if (npc.type == NPCID.ZombieMushroom || npc.type == NPCID.ZombieMushroomHat)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SporeZombieArm>(), 250));
        }

        private static void TryReplaceSpawn(IDictionary<int, float> pool, int vanilla, int replacement, float fraction)
        {
            if (!pool.TryGetValue(vanilla, out float weight) || weight <= 0f)
                return;

            pool[vanilla] = weight * (1f - fraction);
            pool[replacement] = (pool.TryGetValue(replacement, out float existing) ? existing : 0f) + weight * fraction;
        }

        private static void TryGold(NPC npc, int first, int second, int goldType)
        {
            if (npc.type != first && npc.type != second)
                return;
            if (!Main.rand.NextBool(400))
                return;

            npc.Transform(goldType);
        }
    }
}
