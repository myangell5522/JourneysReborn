using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Misc.Materials
{
	public class GhostMatter : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
			ItemID.Sets.ItemIconPulse[Item.type] = true;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 24;

			Item.maxStack = 9999;
			Item.alpha = 120;
		}
	}

    public class GhostMatterDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Ghost || npc.type == NPCID.Wraith || npc.type == NPCID.Reaper || npc.type == NPCID.PirateGhost) {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostMatter>(), 6));
            };
        }
    }
}