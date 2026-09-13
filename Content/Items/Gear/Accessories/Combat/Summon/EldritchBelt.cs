using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using JourneysReborn.NPCs;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Summon
{
	public class EldritchBelt : ModItem
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
            player.GetModPlayer<ShadowBagEffect>().shadowBag += 0.5f;
		}
	}

	public class ShadowBagEffect : ModPlayer{
        public float shadowBag = 1f;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)/* tModPorter If you don't need the Projectile, consider using ModifyHitNPC instead */
        {
            if(shadowBag > 1f && proj.DamageType == DamageClass.Summon) {
                if(target.GetGlobalNPC<NPCStatuses>().isCorruptExtended) {
                    modifiers.FinalDamage *= shadowBag;
                };
            };
        }

        public override void ResetEffects()
        {
            shadowBag = 1f;
        }
    }

	public class EldritchBeltDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.EaterofSouls || npc.type == NPCID.LittleEater || npc.type == NPCID.BigEater) {	
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EldritchBelt>(), 200));
			};
		}
	}
}