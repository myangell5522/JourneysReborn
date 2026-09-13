using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using JourneysReborn.Content.Buffs;
using JourneysReborn.Content.Items.Gear.Tools.Pickaxes;

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class AmberPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 13;
            Item.useAnimation = 17;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 250);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 57;  
        }

        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(80)) {
            player.AddBuff(ModContent.BuffType<GemRushAmber>(), 180);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FossilOre, 8)
                .AddIngredient(ItemID.Amber, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class AmethystPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 3;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 14;
            Item.useAnimation = 22;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 30);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 38;  
        }

        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(100)) {
            player.AddBuff(ModContent.BuffType<GemRushAmethyst>(), 60);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CopperBar, 8)
                .AddIngredient(ItemID.Amethyst, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class DiamondPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 14;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 350);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 59;  
        }

        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(75)) {
            player.AddBuff(ModContent.BuffType<GemRushDiamond>(), 180);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar, 8)
                .AddIngredient(ItemID.Diamond, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class EmeraldPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 4;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 18;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 170);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 50;   
        }

        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(85)) {
            player.AddBuff(ModContent.BuffType<GemRushEmerald>(), 120);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TungstenBar, 8)
                .AddIngredient(ItemID.Emerald, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class RubyPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 16;
            Item.useAnimation = 19;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
 			Item.value = Item.buyPrice(silver: 250);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 57;  
        }

        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(80)) {
            player.AddBuff(ModContent.BuffType<GemRushRuby>(), 180);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 8)
                .AddIngredient(ItemID.Ruby, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class SapphirePickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 4;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 10;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 120);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 48;  
        }
	}	
}
		
namespace JourneysReborn.Content.Items.Gear.Tools.Pickaxes
{
	public class TopazPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 4;
            Item.DamageType = DamageClass.Melee;
            Item.width = 36;
            Item.height = 36;
            Item.useTime = 10;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1.25f;
			Item.value = Item.buyPrice(silver: 120);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
			Item.useTurn = true;

            Item.pick = 40;  
        }
		
        public override bool? UseItem(Player player) {

        if (Main.rand.NextBool(90)) {
            player.AddBuff(ModContent.BuffType<GemRushTopaz>(), 60);
        }
        return base.UseItem(player);
    }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 8)
                .AddIngredient(ItemID.Sapphire, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}