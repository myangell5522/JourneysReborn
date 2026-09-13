using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat
{
	public class MagnifyingGlass : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 20;
			Item.value = Item.buyPrice(gold: 4);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetCritChance(DamageClass.Generic) += 3;
		}
	}

	public class MagnifyingGlassDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.DemonEye || npc.type == NPCID.DemonEye2 || npc.type == NPCID.PurpleEye2 || npc.type == NPCID.GreenEye2 || npc.type == NPCID.DialatedEye2 || npc.type == NPCID.SleepyEye2 || npc.type == NPCID.CataractEye2 || npc.type == NPCID.WanderingEye || npc.type == NPCID.CataractEye || npc.type == NPCID.SleepyEye || npc.type == NPCID.DialatedEye || npc.type == NPCID.GreenEye || npc.type == NPCID.PurpleEye || npc.type == NPCID.DemonEyeOwl || npc.type == NPCID.DemonEyeSpaceship) {	
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<MagnifyingGlass>(), 100, 50));
			};
		}
	}
}