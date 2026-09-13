using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Ranged
{
	[AutoloadEquip(EquipType.Back)]
	public class HellfireQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			// DisplayName.SetDefault("Hellfire Quiver");
			/* Tooltip.SetDefault("Increases arrow damage by 10% and greatly increases arrow speed"
                + "\n20% chance not to consume arrows"
                + "\nLights wooden arrows in the Infernal Fire"
                + "\n'Your enemies will burn in the pain'"); */
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 40);
			Item.rare = ItemRarityID.LightPurple;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.magicQuiver = true;
            player.arrowDamage += 0.1f;
            player.GetModPlayer<HellfireQuiverEffect>().hellfireQuiver = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.MoltenQuiver)
                .AddIngredient(ItemID.HellstoneBar, 15)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}

	public class HellfireQuiverEffect : ModPlayer
    {
        public bool hellfireQuiver;
        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if(hellfireQuiver && type == ProjectileID.WoodenArrowFriendly) {
                if(Main.rand.NextBool(1, 3)) {
                    type = ProjectileID.HellfireArrow;
                } else {
                    type = ProjectileID.FireArrow;
                };
            };
        }
        public override void ResetEffects()
        {
            hellfireQuiver = false;
        }
    }
}