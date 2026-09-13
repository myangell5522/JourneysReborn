using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using JourneysReborn.Content.Items.Gear.Armor.Magic;
using JourneysReborn.Content.Items.Gear.Armor.Summon;

namespace JourneysReborn.Items
{
    public class ArmorSets : GlobalItem
    {
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if(head.type == ModContent.ItemType<FlinxFurHat>() && body.type == ItemID.FlinxFurCoat && legs.type == ModContent.ItemType<FlinxFurPants>()) {
                return "FlinxSet";
            };
			
			bool isBodyValid = body.type == ItemID.GypsyRobe ||
                       body.type == ItemID.AmethystRobe ||
                       body.type == ItemID.AmberRobe ||
                       body.type == ItemID.DiamondRobe ||
                       body.type == ItemID.EmeraldRobe ||
                       body.type == ItemID.RubyRobe ||
                       body.type == ItemID.SapphireRobe ||
                       body.type == ItemID.TopazRobe;
			
 			bool isHeadValid = head.type == ModContent.ItemType<AmethystHat>() ||
                       head.type == ModContent.ItemType<AmberHat>() ||
                       head.type == ModContent.ItemType<DiamondHat>() ||
                       head.type == ModContent.ItemType<EmeraldHat>() ||
                       head.type == ModContent.ItemType<RubyHat>() ||
                       head.type == ModContent.ItemType<SapphireHat>() ||
                       head.type == ModContent.ItemType<TopazHat>();
			if (isBodyValid && isHeadValid)
                return "WizardGemSet";
			
            return null;
            
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if(set == "FlinxSet") {
                player.setBonus = Language.GetTextValue("Mods.JourneysReborn.Items.FlinxFurHat.SetBonus");
				player.whipRangeMultiplier += 0.15f;
            };
			if(set == "WizardGemSet") {
                player.setBonus = Language.GetTextValue("Mods.JourneysReborn.Items.AmberHat.SetBonus");
				player.GetCritChance(DamageClass.Magic) += 0.10f;
            };
        }
    }
}