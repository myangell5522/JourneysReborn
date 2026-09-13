using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Content.Items.Gear.Accessories.Fishing
{
	public class BobberBox : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 34;
			Item.value = Item.buyPrice(gold: 2);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccBobberBox>().bobberBox += 1;
		}
	}

	public class AccBobberBox : ModPlayer
    {
        public short bobberBox = 0;

        public override void ResetEffects()
        {
            bobberBox = 0;
        }
    }

    public class BobberBoxEffect : GlobalItem
    {
        public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if(item.fishingPole > 0 && player.GetModPlayer<AccBobberBox>().bobberBox > 0) {
                for(int i = 0; i < player.GetModPlayer<AccBobberBox>().bobberBox; i++) {
                    Projectile.NewProjectile(source, position, velocity.RotatedByRandom(MathHelper.ToRadians(15)), type, damage, knockback);
                };
            };
            return true;
        }
    }
	
	public class BobberBoxDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Angler) {
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BobberBox>(), 5));
			};

			if(npc.type == NPCID.SleepingAngler) {
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BobberBox>(), 1));
			};
        }
	}
}