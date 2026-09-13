using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using JourneysReborn.Items;

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class AmberHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 3;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 3; 
            player.GetDamage(DamageClass.Magic) += 0.09f;
			player.manaCost -= 0.06f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Amber, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class AmethystHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 1;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 1; 
            player.GetDamage(DamageClass.Magic) += 0.05f;
			player.manaCost -= 0.02f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Amethyst, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class DiamondHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 4;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 4; 
            player.GetDamage(DamageClass.Magic) += 0.1f;
			player.manaCost -= 0.07f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Diamond, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class EmeraldHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 2;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 2; 
            player.GetDamage(DamageClass.Magic) += 0.08f;
			player.manaCost -= 0.05f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Emerald, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class RubyHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 3;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 3; 
            player.GetDamage(DamageClass.Magic) += 0.09f;
			player.manaCost -= 0.06f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Ruby, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class SapphireHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 2;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 2; 
            player.GetDamage(DamageClass.Magic) += 0.07f;
			player.manaCost -= 0.04f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Sapphire, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	

namespace JourneysReborn.Content.Items.Gear.Armor.Magic
{
    [AutoloadEquip(EquipType.Head)]
	public class TopazHat : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.defense = 1;
            Item.rare = ItemRarityID.Green;
            Item.value = 2000; // 20 silver
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 1; 
            player.GetDamage(DamageClass.Magic) += 0.06f;
			player.manaCost -= 0.03f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WizardHat)
				.AddIngredient(ItemID.FallenStar, 3)
                .AddIngredient(ItemID.Topaz, 10)
                .AddTile(TileID.Loom)
                .Register();
				
        }
    }
}	