using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class GoblinShamanMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.defense = 4;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(silver: 15);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.GetModPlayer<GoblinShamanMaskPlayer>().equipped = true;
        }
    }

    public class GoblinShamanMaskPlayer : ModPlayer
    {
        public bool equipped;

        public override void ResetEffects()
        {
            equipped = false;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (!equipped)
                return;

            Extend(target, BuffID.Poisoned, 120);
            Extend(target, BuffID.Venom, 120);
        }

        private static void Extend(NPC target, int buff, int extraTime)
        {
            int index = target.FindBuffIndex(buff);
            if (index >= 0)
                target.buffTime[index] += extraTime;
        }
    }
}
