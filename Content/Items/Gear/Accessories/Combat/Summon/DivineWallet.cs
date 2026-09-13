using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.NPCs;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Summon
{
	public class DivineWallet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 32;
			Item.value = Item.buyPrice(gold: 30);
			Item.rare = ItemRarityID.Pink;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.maxMinions += 1;
            player.GetModPlayer<DivineWalletEffect>().divineWallet += 0.5f;
		}
		
		public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
			if(equippedItem.type == ModContent.ItemType<DivineWallet>() | 
			equippedItem.type == ModContent.ItemType<AngelicShadowBag>() |
			equippedItem.type == ModContent.ItemType<BlessedVesica>()) {
				return false;
			};
            return true;
        }
	}

	public class DivineWalletEffect : ModPlayer{
        public float divineWallet = 1f;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)/* tModPorter If you don't need the Projectile, consider using ModifyHitNPC instead */
        {
            if(divineWallet > 1f && proj.DamageType == DamageClass.Summon) {
                if(target.GetGlobalNPC<NPCStatuses>().isHallowed) {
                    modifiers.FinalDamage *= divineWallet;
                };
            };
        }

        public override void ResetEffects()
        {
            divineWallet = 1f;
        }
    }

	public class DivineWalletDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Gastropod) {
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DivineWallet>(), 100));
			};
		}
	}
}