using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Ranged
{
	[AutoloadEquip(EquipType.Back)]
	public class RobinsQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 35);
			Item.rare = ItemRarityID.Pink;
			Item.accessory = true;
			Item.defense = 3;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.magicQuiver = true;
            player.arrowDamage += 0.15f;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.MagicQuiver)
                .AddIngredient(ItemID.RangerEmblem)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}