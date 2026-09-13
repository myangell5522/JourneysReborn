using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class AnxietyRadar : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 32;
			Item.value = Item.buyPrice(silver: 55);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccAnxietyRadar>().anxietyRadar = true;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddRecipeGroup(nameof(ItemID.CopperBar), 8)
                .AddRecipeGroup(RecipeGroupID.IronBar, 8)
                .AddRecipeGroup(nameof(ItemID.SilverBar), 8)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 8)
                .AddIngredient(ItemID.PinkGel, 10)
                .AddTile(TileID.Anvils)
				.Register();
		}
	}

    public class AccAnxietyRadar : ModPlayer
    {
        public bool anxietyRadar;

        public override void ResetEffects()
        {
            anxietyRadar = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<AnxietyRadar>()) || Player.HasItem(ModContent.ItemType<MiniTracker>())) {
                Player.GetModPlayer<AccAnxietyRadar>().anxietyRadar = true;
            }
        }
    }

    class AnxietyRadarDisplay : InfoDisplay
    {
        public override void SetStaticDefaults() {
			// DisplayName.SetDefault("Aggro");
		}
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccAnxietyRadar>().anxietyRadar;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */ {
			if(Main.LocalPlayer.aggro >= 0) displayColor = Main.LocalPlayer.aggro > 0 ? Color.Red : InactiveInfoTextColor;
			return Main.LocalPlayer.aggro >= 0 ? $"{Main.LocalPlayer.aggro} " + Language.GetTextValue("Mods.JourneysReborn.InfoText.Aggro") : $"{-Main.LocalPlayer.aggro} " + Language.GetTextValue("Mods.JourneysReborn.InfoText.Deaggro");
		}
    }
}