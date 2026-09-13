using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Magic
{
	public class MagicCrystal : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Magic Crystal");
			// Tooltip.SetDefault("10% chance to not consume mana");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 24;
			Item.scale = 3f;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccMagicCrystal>().magicCrystal = true;
		}
	}

	public class AccMagicCrystal : ModPlayer
    {
        public bool magicCrystal;
        public override void OnConsumeMana(Item item, int manaConsumed)
        {
            if(magicCrystal && Main.rand.NextBool(15)) {
                Player.statMana += manaConsumed;
            };
        }
        public override void ResetEffects()
        {
            magicCrystal = false;
        }
    }

	public class MagicCrystalDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.GoblinSorcerer) {	
				npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<MagicCrystal>(), 200, 100));  
			};;
		}
	}
}