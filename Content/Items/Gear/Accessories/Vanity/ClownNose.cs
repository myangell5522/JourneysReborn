using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Vanity
{
	[AutoloadEquip(EquipType.Beard)]
	public class ClownNose : ModItem
	{
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 8;
			Item.scale = 30f;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
            Item.vanity = true;
		}
	}

    public class ClownNoseDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Clown) npcLoot.Add(ItemDropRule.WithRerolls(ModContent.ItemType<ClownNose>(), 21, 100));
        }
    }
}