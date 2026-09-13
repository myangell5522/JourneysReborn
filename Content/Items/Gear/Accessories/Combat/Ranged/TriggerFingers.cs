using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Ranged
{
	[AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff)]
	public class TriggerFingers : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 10);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccTriggerFingers>().triggerFingers = true;
			player.GetAttackSpeed(DamageClass.Ranged) += 0.10f;
		}
	}

	public class AccTriggerFingers : ModPlayer
    {
        public bool triggerFingers;
        public override bool? CanAutoReuseItem(Item item)
        {
            if(triggerFingers && item.DamageType == DamageClass.Ranged) {
                return true;
            } else {
                return null;
            }
        } 
        public override void ResetEffects()
        {
            triggerFingers = false;
        }
    }

	public class TriggerFingersDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.GoblinArcher) {
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<TriggerFingers>(), 200, 100));
			};
		}
	}
}