using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Magic
{
	[AutoloadEquip(EquipType.HandsOn)]
	public class SorcerersBand : ModItem
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
            player.GetModPlayer<AccSorcerersBand>().manaBonus += 0.15f;
		}
	}

    public class AccSorcerersBand : ModPlayer
    {
        public float manaBonus = 1f;
        public override void GetHealMana(Item item, bool quickHeal, ref int healValue)
        {
            healValue = (int)(healValue * manaBonus);
        }
        public override void ResetEffects()
        {
            manaBonus = 1f;
        }
    }
}