using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;
using JourneysReborn.Content.Items.Gear.Accessories.Informational_Building;
namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
	public class Cardiograph : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 36;
			Item.height = 22;
			Item.value = Item.buyPrice(gold: 1, silver: 75);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccCardiograph>().cardiograph = true;
		}
	}

    public class AccCardiograph : ModPlayer
    {
        public bool cardiograph;

        public override void ResetEffects()
        {
            cardiograph = false;
        }
        public override void PostUpdate()
        {
            if(Player.HasItem(ModContent.ItemType<Cardiograph>()) || Player.HasItem(ModContent.ItemType<HeartRateMonitor>()) || Player.HasItem(ModContent.ItemType<MiniTracker>())) {
                Player.GetModPlayer<AccCardiograph>().cardiograph = true;
            }
        }
    }

    class CardiographDisplay : InfoDisplay
    {
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<AccCardiograph>().cardiograph;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */ {
			if(Main.LocalPlayer.lifeRegen == 0) displayColor = InactiveInfoTextColor;
			return Main.LocalPlayer.lifeRegen >= 0 ? $"{Main.LocalPlayer.lifeRegen / 2} " + Language.GetTextValue("Mods.JourneysReborn.InfoText.LifeRegen") : $"{-Main.LocalPlayer.lifeRegen / 2} " + Language.GetTextValue("Mods.JourneysReborn.InfoText.LifeDamage");
		}
    }

	public class CardiographDrop : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.EaterofSouls || npc.type == NPCID.LittleEater || npc.type == NPCID.BigEater || npc.type == NPCID.Crimera || npc.type == NPCID.LittleCrimera || npc.type == NPCID.BigCrimera) npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Cardiograph>(), 200, 100));
        }
	}
}