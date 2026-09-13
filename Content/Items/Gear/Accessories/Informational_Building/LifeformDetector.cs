using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class LifeformDetectorCorruption : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 32;
			Item.value = Item.buyPrice(gold: 2, silver: 50);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccLifeformDetector>().lifeformDetector = true;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.DemoniteBar, 8)
                .AddIngredient(ItemID.Diamond, 3)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddIngredient(ItemID.Glass, 10)
                .AddTile(TileID.Anvils)
				.Register();
		}
	}

    public class LifeformDetectorCrimson : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Lifeform Detector");
			// Tooltip.SetDefault("Displays total amout of rare creatures around you");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 32;
			Item.value = Item.buyPrice(gold: 2, silver: 50);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccLifeformDetector>().lifeformDetector = true;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.CrimtaneBar, 8)
                .AddIngredient(ItemID.Diamond, 3)
                .AddIngredient(ItemID.Ruby, 5)
                .AddIngredient(ItemID.Glass, 10)
                .AddTile(TileID.Anvils)
				.Register();
		}
	}

    public class AccLifeformDetector : ModPlayer
    {
        public bool lifeformDetector;

        public override void ResetEffects()
        {
            lifeformDetector = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<LifeformDetectorCorruption>()) || Player.HasItem(ModContent.ItemType<LifeformDetectorCrimson>()) || Player.HasItem(ModContent.ItemType<MiniTracker>())) {
                Player.GetModPlayer<AccLifeformDetector>().lifeformDetector = true;
            }
        }
    }

    class LifeformDetectorDisplay : InfoDisplay
    {
        public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Amount of Rare Creatures Nearby");
		}
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccLifeformDetector>().lifeformDetector;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */ {
            int creatures = RareCreatures(Main.LocalPlayer);
			if(creatures == 0) displayColor = InactiveInfoTextColor;
			return creatures > 0 ? $"{creatures} " + Language.GetTextValue("Mods.JourneysReborn.InfoText.RareCreaturesNearby") : Language.GetTextValue("Mods.JourneysReborn.InfoText.NoRareCreatures");
		}

        int RareCreatures(Player player) {
            int total = 0;
            for(int i = 0; i < Main.maxNPCs; i++) {
                NPC npc = Main.npc[i];
                if(npc.active && npc.rarity > 0 && npc.Distance(player.position) <= 1800f) total++;
            };
            return total;
        }
    }
}