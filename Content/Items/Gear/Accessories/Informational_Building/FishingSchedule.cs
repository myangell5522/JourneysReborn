using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Localization;
using JourneysReborn.Content.Items.Gear.Accessories.Informational_Building;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class FishingSchedule : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Fishing Schedule");
			/* Tooltip.SetDefault("Displays today's quest fish"
            +"\n'That's your quest fish for today'"); */
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 24;
			Item.value = Item.buyPrice(silver: 55);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccFishingSchedule>().fishingSchedule = true;
		}
	}

    public class AccFishingSchedule : ModPlayer
    {
        public bool fishingSchedule;

        public override void ResetEffects()
        {
            fishingSchedule = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<FishingSchedule>())) {
                Player.GetModPlayer<AccFishingSchedule>().fishingSchedule = true;
            };
			if(Player.HasItem(ModContent.ItemType<MarinersDevice>())) {
				Player.accFishFinder = true;
				Player.accWeatherRadio = true;
				Player.accCalendar = true;
            	Player.GetModPlayer<AccFishingSchedule>().fishingSchedule = true;
			};
        }
    }

    class FishingScheduleDisplay : InfoDisplay
    {
        public override void SetStaticDefaults() {
		}
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccFishingSchedule>().fishingSchedule;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */ {
            Item fish = new Item(Main.anglerQuestItemNetIDs[Main.anglerQuest]);
			if(!NPC.savedAngler) displayColor = InactiveInfoTextColor;
			return NPC.savedAngler ? fish.Name : Language.GetTextValue("Mods.JourneysReborn.InfoText.AnglerNotSaved");
		}
    }
}