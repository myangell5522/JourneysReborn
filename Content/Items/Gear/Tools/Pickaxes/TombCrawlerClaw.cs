using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class TombCrawlerClaw : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 3;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
            Item.scale = 0.75f;
			Item.useTime = 5;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 1.5f;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.useTurn = true;

			Item.pick = 25;
            Item.tileBoost -= 1;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if(Main.rand.NextBool(10)) {
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.DesertPot);
			}
		}
	}

	public class TTClawDrop : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.TombCrawlerHead || npc.type == NPCID.DuneSplicerHead) {	
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TombCrawlerClaw>(), 8));
			};
		}
	}
}