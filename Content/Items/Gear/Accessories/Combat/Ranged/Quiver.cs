using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Ranged
{
	[AutoloadEquip(EquipType.Back)]
	public class Quiver : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Quiver");
			// Tooltip.SetDefault("10% chance to not consume arrows");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 3);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccQuiver>().quiver= true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.WoodenArrow, 500)
                .AddIngredient(ItemID.Leather, 10)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}

	public class AccQuiver : ModPlayer
    {
        public bool quiver;
        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            if(quiver && ammo.ammo == AmmoID.Arrow && Main.rand.NextBool(10)) {
                return false;
            } else {
                return true;
            };
        }
        public override void ResetEffects()
        {
            quiver = false;
        }
    }
}