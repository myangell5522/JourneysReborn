using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Fishing
{
	[AutoloadEquip(EquipType.Back)]
	public class ProfessionalTackleBox : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 34;
			Item.value = Item.buyPrice(gold: 16);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccBobberBox>().bobberBox += 1;
            player.accFishingLine = true;
            player.accTackleBox = true;
            player.fishingSkill += 20;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.AnglerTackleBag)
                .AddIngredient(ItemID.FishingBobber)
                .AddIngredient(ModContent.ItemType<BobberBox>())
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            if(equippedItem.type == Type && incomingItem.type == ItemID.AnglerTackleBag) return false;
			if(equippedItem.type == ItemID.AnglerTackleBag && incomingItem.type == Type) return false;
			return true;
        }
	}
}