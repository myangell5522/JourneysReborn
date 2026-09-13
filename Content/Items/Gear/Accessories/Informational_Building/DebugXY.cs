using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class DebugXY : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 38;
			Item.height = 34;
			Item.value = Item.sellPrice(platinum: 9999);
			Item.rare = ItemRarityID.Quest;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccAnxietyRadar>().anxietyRadar = true;
            player.GetModPlayer<AccCardiograph>().cardiograph = true;
            player.GetModPlayer<AccLifeformDetector>().lifeformDetector = true;
		}
	}

    public class AccDebugXY : ModPlayer
    {
        public bool debugXY;

        public override void ResetEffects()
        {
            debugXY = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<DebugXY>())) {
                Player.GetModPlayer<AccDebugXY>().debugXY = true;
            }
        }
    }

    class DebugXYDisplay : InfoDisplay
    {
        public override void SetStaticDefaults() {
		}
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccDebugXY>().debugXY;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor) {
            return $"({Main.LocalPlayer.position.ToTileCoordinates().X}, {Main.LocalPlayer.position.ToTileCoordinates().Y})";
		}
    }
}