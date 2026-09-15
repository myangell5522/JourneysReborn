using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;

namespace JourneysReborn.Content.NPCs.Biomes.Mushrooms
{
    public class SporeZombieArmed : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 7;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.ZombieMushroom);
            NPC.damage = 78;
            AIType = NPCID.ZombieMushroom;
            NPC.value = Item.sellPrice(silver: 10);
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.UndergroundMushroom,
                new FlavorTextBestiaryInfoElement("A spore-infected zombie swinging a mushroom-crusted arm.")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.spriteDirection = NPC.direction;
            if (NPC.velocity.Y != 0f)
            {
                NPC.frame.Y = frameHeight * 4;
                return;
            }

            NPC.frameCounter += 0.2;
            if (NPC.frameCounter > 4)
            {
                NPC.frameCounter = 0;
                NPC.frame.Y += frameHeight;
                if (NPC.frame.Y >= frameHeight * 7)
                    NPC.frame.Y = 0;
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SporeZombieArm>(), 50));
        }
    }
}
