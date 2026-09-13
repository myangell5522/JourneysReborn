using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Accessories.Defensive;

namespace JourneysReborn.Content.Items.Gear.Accessories.Movement
{
    [AutoloadEquip(EquipType.Shoes)]
	public class HadessBoots : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 32;
            Item.value = Item.sellPrice(gold: 7);
            Item.rare = ItemRarityID.Pink; 
            Item.accessory = true;
            Item.defense = 2; 
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = true;
            player.noFallDmg = true;
            player.fireWalk = true;
            player.luck += 0.05f;
            player.wingTimeMax = 0;
            player.accRunSpeed = 6f;
            player.maxRunSpeed = 6f; 			
            player.rocketBoots = 1; 
            player.fireWalk = true;
			player.buffImmune[BuffID.Burning] = true;
        }
		
		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.HellfireTreads)
                .AddIngredient(ModContent.ItemType<RustyHorseshoe>())
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}