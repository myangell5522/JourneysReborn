using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace JourneysReborn.Content.Items.Misc.Materials
{
	public class Shadowflame : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 26;

			Item.maxStack = 9999; 
			Item.value = Item.buyPrice(silver: 18);
		}
	}

	public class ShadowflameDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.GoblinSummoner) {	
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Shadowflame>(), 1, 6, 14));
			};
		}
	}
}