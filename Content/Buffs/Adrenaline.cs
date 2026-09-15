using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Adrenaline : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            float healthPercent = (float)player.statLife / player.statLifeMax2;

            float damageAndSpeed;
            int defensePenalty;

            if (healthPercent < 0.2f)
            {
                damageAndSpeed = 0.30f;
                defensePenalty = 15;
            }
            else if (healthPercent < 0.5f)
            {
                damageAndSpeed = 0.20f;
                defensePenalty = 10;
            }
            else
            {
                damageAndSpeed = 0.10f;
                defensePenalty = 5;
            }

            player.GetDamage(DamageClass.Generic) += damageAndSpeed;
            player.moveSpeed += damageAndSpeed;
            player.statDefense -= defensePenalty;
        }
    }
}
