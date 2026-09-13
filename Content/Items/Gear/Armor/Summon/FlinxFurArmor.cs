using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using JourneysReborn.Items;

namespace JourneysReborn.Content.Items.Gear.Armor.Summon
{
    [AutoloadEquip(EquipType.Head)]
	public class FlinxFurHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.defense = 1;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 1; 
            player.GetDamage(DamageClass.Summon) += 0.03f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 6)
                .AddIngredient(ItemID.FlinxFur, 6)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Summon
{
    [AutoloadEquip(EquipType.Legs)]
	public class FlinxFurPants : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.defense = 2;
            Item.rare = ItemRarityID.Green;
            Item.value = 20000; // 2 gold
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 2;
            player.GetDamage(DamageClass.Summon) += 0.04f;
            player.moveSpeed += 0.05f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 8)
                .AddIngredient(ItemID.FlinxFur, 8)
                .AddIngredient(ItemID.GoldBar, 8)
                .AddTile(TileID.Loom)
                .Register();
		
		    CreateRecipe()
                .AddIngredient(ItemID.Silk, 8)
                .AddIngredient(ItemID.FlinxFur, 8)
                .AddIngredient(ItemID.PlatinumBar, 8)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}