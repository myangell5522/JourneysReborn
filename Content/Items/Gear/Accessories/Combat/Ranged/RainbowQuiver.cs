using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using JourneysReborn.Content.Items.Gear.Weapons.Ammo;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Ranged
{
	[AutoloadEquip(EquipType.Back)]
	public class RainbowQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.value = Item.buyPrice(gold: 60);
			Item.rare = ItemRarityID.Cyan;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.magicQuiver = true;
            player.GetModPlayer<RainbowQuiverEffect>().rainbowQuiver = true;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.MagicQuiver)
                .AddIngredient(ItemID.SoulofNight, 10)
                .AddIngredient(ItemID.SoulofLight, 10)
                .AddIngredient(ItemID.SoulofFright, 5)
                .AddIngredient(ItemID.SoulofMight, 5)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();

            CreateRecipe()
                .AddIngredient(ItemID.MagicQuiver)
                .AddIngredient(ItemID.SoulofNight, 10)
                .AddIngredient(ItemID.SoulofLight, 10)
                .AddIngredient(ItemID.SoulofFright, 5)
                .AddIngredient(ItemID.SoulofSight, 5)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();

            CreateRecipe()
                .AddIngredient(ItemID.MagicQuiver)
                .AddIngredient(ItemID.SoulofNight, 10)
                .AddIngredient(ItemID.SoulofLight, 10)
                .AddIngredient(ItemID.SoulofMight, 5)
                .AddIngredient(ItemID.SoulofSight, 5)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}

	public class RainbowQuiverEffect : ModPlayer
    {
        public bool rainbowQuiver;
        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if(rainbowQuiver && type == ProjectileID.WoodenArrowFriendly) {
                if(Main.rand.NextBool(1, 2)) {
                    type = Main.rand.NextFromList(
                        ProjectileID.FlamingArrow,
                        ProjectileID.UnholyArrow,
                        ProjectileID.JestersArrow,
                        ProjectileID.HellfireArrow,
                        ProjectileID.HolyArrow,
                        ProjectileID.CursedArrow,
                        ProjectileID.FrostburnArrow,
                        ProjectileID.ChlorophyteArrow,
                        ProjectileID.IchorArrow,
                        ProjectileID.VenomArrow,
                        ProjectileID.BoneArrow,
                        ProjectileID.ShadowFlameArrow,
                        ProjectileID.ShimmerArrow,
                        ModContent.ProjectileType<JaggedArrowProj>());
                };
            };
        }
        public override void ResetEffects()
        {
            rainbowQuiver = false;
        }
    }
}