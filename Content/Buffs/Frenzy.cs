using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Frenzy : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<FrenzyPlayer>().frenzy = true;
        }
    }

    public class FrenzyPlayer : ModPlayer
    {
        public const float VanillaCritKnockbackMultiplier = 1.4f;
        public const float FrenzyCritKnockbackMultiplier = 1.6f;

        public bool frenzy;

        public override void ResetEffects()
        {
            frenzy = false;
        }

        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if (!frenzy)
                return;

            modifiers.CritDamage += 0.5f;
            modifiers.ModifyHitInfo += static (ref NPC.HitInfo info) =>
            {
                if (info.Crit)
                    info.Knockback *= FrenzyCritKnockbackMultiplier / VanillaCritKnockbackMultiplier;
            };
        }
    }
}
