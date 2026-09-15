using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Items.Gear.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MechanicHelmet : ModItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Gear/Armor/GoblinMechanicHelmet";

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.defense = 5;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(silver: 20);
        }

        public override void UpdateEquip(Player player)
        {
            player.InfoAccMechShowWires = true;
            player.GetModPlayer<MechanicHelmetPlayer>().equipped = true;
        }
    }

    public class MechanicHelmetPlayer : ModPlayer
    {
        private static readonly int[] TrapDebuffs = { BuffID.OnFire, BuffID.OnFire3, BuffID.Poisoned, BuffID.Venom, BuffID.CursedInferno, BuffID.Frostburn, BuffID.Frostburn2 };

        public bool equipped;
        private bool shrinkTrapDebuffs;

        public override void ResetEffects()
        {
            equipped = false;
        }

        public override void ModifyHurt(ref Player.HurtModifiers modifiers)
        {
            if (!equipped || !IsTrap(modifiers.DamageSource))
                return;

            modifiers.FinalDamage *= 0.67f;
        }

        public override void OnHitByProjectile(Projectile projectile, Player.HurtInfo hurtInfo)
        {
            if (equipped && projectile.trap)
                shrinkTrapDebuffs = true;
        }

        public override void PostUpdateBuffs()
        {
            if (!shrinkTrapDebuffs)
                return;

            shrinkTrapDebuffs = false;
            if (!equipped)
                return;

            for (int i = 0; i < Player.MaxBuffs; i++)
            {
                int type = Player.buffType[i];
                if (type <= 0)
                    continue;

                for (int d = 0; d < TrapDebuffs.Length; d++)
                {
                    if (type == TrapDebuffs[d] && Player.buffTime[i] > 1)
                    {
                        Player.buffTime[i] = (int)(Player.buffTime[i] * 0.67f);
                        break;
                    }
                }
            }
        }

        private static bool IsTrap(PlayerDeathReason source)
        {
            if (source.SourceProjectileLocalIndex >= 0 && source.SourceProjectileLocalIndex < Main.maxProjectiles)
            {
                Projectile proj = Main.projectile[source.SourceProjectileLocalIndex];
                if (proj.active && proj.trap)
                    return true;
            }

            return false;
        }
    }
}
