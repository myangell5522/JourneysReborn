using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Accessories.Informational_Building
{
    [AutoloadEquip(EquipType.Face)]
    public class Ocular : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() {
            Item.width = 28;
            Item.height = 24;
            Item.value = Item.buyPrice(gold: 10);
            Item.rare = ItemRarityID.Lime;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.dangerSense = true;
            player.detectCreature = true;
            player.CanSeeInvisibleBlocks = true;
            player.buffImmune[BuffID.Darkness] = true;
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
                .AddIngredient(ModContent.ItemType<Smartglasses>())
                .AddIngredient(ItemID.SpectreGoggles)
                .AddIngredient(ItemID.Blindfold)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}