using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Defensive.Survivability
{
	[AutoloadEquip(EquipType.HandsOn)]
	public class BandOfRecovery : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccBandOfRecovery>().healBonus += 0.15f;
		}
	}

    public class AccBandOfRecovery : ModPlayer
    {
        public float healBonus = 1f;
        public override void GetHealLife(Item item, bool quickHeal, ref int healValue)
        {
            healValue = (int)(healValue * healBonus);
        }
        public override void ResetEffects()
        {
            healBonus = 1f;
        }
    }
}