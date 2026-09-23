using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Weapons.Melee.Swords;
using JourneysReborn.Content.NPCs;

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
                new FlavorTextBestiaryInfoElement("Mods.JourneysReborn.Bestiary.BloodZombieArmed")
            });
        }

        public override void FindFrame(int frameHeight)
        {
            ArmedZombieAnimation.FindFrame(NPC, frameHeight);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BloodZombieArm>(), 50));
        }
    }
}
