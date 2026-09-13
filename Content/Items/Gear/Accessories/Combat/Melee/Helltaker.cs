using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace JourneysReborn.Content.Items.Gear.Accessories.Combat.Melee
{
	public class Helltaker : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 30;
			Item.value = Item.buyPrice(gold: 16);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<AccHelltaker>().helltaker += 0.35f;
		}

        public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<Backstabber>())
                .AddIngredient(ItemID.HellstoneBar, 15)
                .AddIngredient(ItemID.Obsidian, 20)
                .AddIngredient(ItemID.MagmaStone)
                .AddTile(TileID.Hellforge)
				.Register();
		}

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
			if(equippedItem.type == ModContent.ItemType<Backstabber>() || incomingItem.type == ModContent.ItemType<Backstabber>()) {
				return false;
			};
            return true;
        }
	}

	public class AccHelltaker : ModPlayer
    {
        public float helltaker = 1f;
        public override void ModifyHitNPCWithItem(Item item, NPC target, ref NPC.HitModifiers modifiers)
        {
            if(helltaker != 1f && (target.velocity.X * Player.velocity.X > 0)) {
                modifiers.SetCrit();
                modifiers.FinalDamage *= helltaker;
                target.AddBuff(BuffID.OnFire3, Main.rand.Next(180, 301));
            };
        }
        public override void ResetEffects()
        {
            helltaker = 1f;
        }
    }
}