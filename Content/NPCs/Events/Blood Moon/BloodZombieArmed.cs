using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;

namespace JourneysReborn.Content.NPCs.Events.BloodMoon
{
    public class BloodZombieArmed : ModNPC
    {
        public override string Texture => "JourneysReborn/Content/NPCs/Events/Blood Moon/BloodZombieArmed";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 7;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.BloodZombie);
            NPC.damage = 38;
            AIType = NPCID.BloodZombie;
            NPC.value = Item.sellPrice(silver: 1, copper: 50);
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Events.BloodMoon,
                new FlavorTextBestiaryInfoElement("A blood zombie still clutching a severed arm as a weapon.")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            // 7-frame sheet: keep the extra overhead-swing frames in use while walking.
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
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodZombieArm>(), 50));
        }
    }
}
