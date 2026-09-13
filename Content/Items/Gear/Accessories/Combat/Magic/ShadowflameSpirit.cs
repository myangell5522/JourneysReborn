using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using JourneysReborn.Items;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Magic
{
	[AutoloadEquip(EquipType.Face)]
	public class ShadowflameSpirit : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 36;
			Item.value = Item.buyPrice(gold: 20);
			Item.rare = ItemRarityID.LightPurple;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccShadowflameSpirit>().shadowflameSpirit = true;
		}
	}

	public class ShadowflameSpiritDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.GoblinSummoner) {	
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<ShadowflameSpirit>(), 30, 15));  
			};
		}
	}
}