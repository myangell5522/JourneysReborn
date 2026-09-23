using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;
using JourneysReborn.Content.NPCs;

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
                new FlavorTextBestiaryInfoElement("Mods.JourneysReborn.Bestiary.SporeZombieArmed")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            ArmedZombieAnimation.FindFrame(NPC, frameHeight);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SporeZombieArm>(), 50));
        }
    }
}
