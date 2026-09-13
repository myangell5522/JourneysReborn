using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Melee
{
	public class Backstabber : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 26;
			Item.value = Item.buyPrice(gold: 12);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccBackstabber>().backstabber += 0.25f;
		}
	}

	public class AccBackstabber : ModPlayer
    {
        public float backstabber = 1f;
        public override void ModifyHitNPCWithItem(Item item, NPC target, ref NPC.HitModifiers modifiers)
        {
            if(backstabber != 1f && (target.velocity.X * Player.velocity.X > 0)) {
                modifiers.SetCrit();
                modifiers.FinalDamage *= backstabber;
            };
        }
        public override void ResetEffects()
        {
            backstabber = 1f;
        }
    }

	public class BackstabberDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.GoblinThief) {
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Backstabber>(), 200, 100));
			};
		}
	}
}