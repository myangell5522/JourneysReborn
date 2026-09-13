using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using JourneysReborn.NPCs;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Summon
{
	public class VesicaUrinaria : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 20);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.maxMinions += 1;
            player.GetModPlayer<VesicaUrinariaEffect>().vesicaUrinaria += 0.5f;
		}
		
		public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
			if(equippedItem.type == ModContent.ItemType<VesicaUrinaria>() | 
			equippedItem.type == ModContent.ItemType<BlessedVesica>()) {
				return false;
			};
            return true;
        }
	}

	public class VesicaUrinariaEffect : ModPlayer {
        public float vesicaUrinaria = 1f;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)/* tModPorter If you don't need the Projectile, consider using ModifyHitNPC instead */
        {
            if(vesicaUrinaria > 1f && proj.DamageType == DamageClass.Summon) {
                if(target.GetGlobalNPC<NPCStatuses>().isCrimsonExtended) {
                    modifiers.FinalDamage *= vesicaUrinaria;
                };
            };
        }

        public override void ResetEffects()
        {
            vesicaUrinaria = 1f;
        }
    }

	public class VesicaUrinariaDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Crimera || npc.type == NPCID.LittleCrimera || npc.type == NPCID.BigCrimera) {	
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<VesicaUrinaria>(), 200));
			};
		}
	}
}