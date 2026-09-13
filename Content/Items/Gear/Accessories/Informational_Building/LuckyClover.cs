using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class LuckyClover : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Lucky Clover");
			/* Tooltip.SetDefault("Displays luck"
                + "\n'14 years of bad luck'"); */
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 24;
			Item.value = Item.buyPrice(gold: 2, silver: 50);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccLuckyClover>().luckyClover += 0.1f;
            player.GetModPlayer<AccLuckyClover>().luckyCloverDisplay = true;
		}
	}

    public class AccLuckyClover : ModPlayer
    {
        public float luckyClover;
        public bool luckyCloverDisplay;
        public override void ModifyLuck(ref float luck)
        {
            if(luckyClover > 0) {
                luck += luckyClover;
            };
        }

        public override void ResetEffects()
        {
            luckyClover = 0;
            luckyCloverDisplay = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<LuckyClover>()) || Player.HasItem(ModContent.ItemType<MiniTracker>())) {
                Player.GetModPlayer<AccLuckyClover>().luckyCloverDisplay = true;
            }
        }
    }

    class LuckyCloverDisplay : InfoDisplay
    {
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccLuckyClover>().luckyCloverDisplay;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor) {
			double luckValue = System.Math.Round((Main.LocalPlayer.luck * 100), 2);
            if(luckValue == 0) displayColor = InactiveInfoTextColor;
            return $"{System.Math.Abs(luckValue)} " + Language.GetTextValue(luckValue >= 0 ? "Mods.JourneysReborn.InfoText.Luck" : "Mods.JourneysReborn.InfoText.BadLuck");
		}
    }

    public class LuckyCloverDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.Gnome) npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<LuckyClover>(), 20, 10));
        }
    }
}