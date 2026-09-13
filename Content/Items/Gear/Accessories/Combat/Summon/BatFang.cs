using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Summon
{
	public class BatFang : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 18;
			Item.value = Item.buyPrice(gold: 12);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<BatFangEffect>().batFang = true;
		}
	}

	public class BatFangEffect : ModPlayer
    {
        public bool batFang;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)/* tModPorter If you don't need the Projectile, consider using ModifyHitNPC instead */
        {
            if(batFang && proj.DamageType == DamageClass.Summon) {
                if(Main.rand.NextBool(15)) {
                    target.AddBuff(Main.rand.NextFromList(BuffID.Venom, BuffID.Poisoned, BuffID.Confused), Main.rand.Next(60, 180), false);
                };
            };
        }
        public override void ResetEffects()
        {
            batFang = false;
        }
    }

	public class BatFangDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.CaveBat || npc.type == NPCID.SporeBat || npc.type == NPCID.JungleBat || npc.type == NPCID.Hellbat || npc.type == NPCID.IceBat || npc.type == NPCID.GiantBat || npc.type == NPCID.IlluminantBat || npc.type == NPCID.Lavabat || npc.type == NPCID.GiantFlyingFox) {	
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BatFang>(), 400));
			};
		}
	}
}