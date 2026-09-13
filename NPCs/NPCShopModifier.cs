using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Accessories.Vanity;
using JourneysReborn.Content.Items.Gear.Accessories.Defensive;

namespace JourneysReborn.NPCs
{
    public class NPCShopModifier : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public override void ModifyShop(NPCShop shop)
        {
            if(shop.NpcType == NPCID.Merchant) {
                shop.Add(ItemID.Umbrella, Condition.InRain);
                //shop.Add(ModContent.ItemType<NursingPact>(), Condition.NpcIsPresent(NPCID.Nurse));
            };

            if(shop.NpcType == NPCID.Dryad) {
                shop.Add(ModContent.ItemType<DryadsAmulet>());
            };

            //if(shop.NpcType == NPCID.PartyGirl) {
                //shop.Add(ModContent.ItemType<Smile>(), Condition.DownedClown);
            //};

            //if(shop.NpcType == NPCID.Demolitionist) {
                //shop.Add(ModContent.ItemType<DemolitionistGlove>(), Condition.DownedSkeletron);
            //};

            if(shop.NpcType == NPCID.Stylist) {
                shop.Add(ModContent.ItemType<FancyBlackHeels>(), Condition.MoonPhaseFull);
                shop.Add(ModContent.ItemType<FancyBlueHeels>(), Condition.MoonPhaseWaningGibbous);
                shop.Add(ModContent.ItemType<FancyGreenHeels>(), Condition.MoonPhaseThirdQuarter);
                shop.Add(ModContent.ItemType<FancyPinkHeels>(), Condition.MoonPhaseWaningCrescent);
                shop.Add(ModContent.ItemType<FancyRedHeels>(), Condition.MoonPhaseNew);
                shop.Add(ModContent.ItemType<FancyVioletHeels>(), Condition.MoonPhaseWaxingCrescent);
                shop.Add(ModContent.ItemType<FancyWhiteHeels>(), Condition.MoonPhaseFirstQuarter);
                shop.Add(ModContent.ItemType<FancyYellowHeels>(), Condition.MoonPhaseWaxingGibbous);
            };
        }
    }
}