using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
    [AutoloadEquip(EquipType.Face)]
    public class Smartglasses : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() {
            Item.width = 28;
            Item.height = 24;
            Item.value = Item.buyPrice(gold: 5);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.dangerSense = true;
            player.detectCreature = true;
        }

        public override void UpdateInventory(Player player) {
            player.builderAccStatus[Player.BuilderAccToggleIDs.WireVisibility_Red] = 1;
            player.builderAccStatus[Player.BuilderAccToggleIDs.WireVisibility_Green] = 1;
            player.builderAccStatus[Player.BuilderAccToggleIDs.WireVisibility_Blue] = 1;
            player.builderAccStatus[Player.BuilderAccToggleIDs.WireVisibility_Yellow] = 1;
            player.builderAccStatus[Player.BuilderAccToggleIDs.WireVisibility_Actuators] = 1;
        }
        
        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.MechanicalLens)
                .AddIngredient(ModContent.ItemType<DangersenseLens>())
                .AddIngredient(ModContent.ItemType<HunterLens>())
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}