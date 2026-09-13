using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Summon
{
	public class AngelicShadowBag : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 28;
			Item.scale = 3f;
			Item.value = Item.buyPrice(gold: 40);
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.maxMinions += 1;
            player.GetModPlayer<ShadowBagEffect>().shadowBag += 0.5f;
            player.GetModPlayer<DivineWalletEffect>().divineWallet += 0.5f;
		}

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<EldritchBelt>())
                .AddIngredient(ModContent.ItemType<DivineWallet>())
				.AddIngredient(ItemID.ShadowScale, 20)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}