using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Items;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Magic
{
	public class ForbiddenPage : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Forbidden Page");
			/* Tooltip.SetDefault("Most spell tomes gain special effects"
                + "\n'Treatise on Foes'"); */
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 24;
			Item.value = Item.buyPrice(gold: 20);
			Item.rare = ItemRarityID.LightPurple;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccForbiddenPage>().forbiddenPage = true;
		}
	}
}