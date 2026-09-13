using Terraria;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Consumables.Potions;

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
            // Получаем наш ModPlayer
            var modPlayer = player.GetModPlayer<PalladiumPlayer>();

            float healthPercent = (float)player.statLife / player.statLifeMax2;

            // По умолчанию все бонусы = 0 (если здоровье >= 50%)
            float speed = 0f;
            int regen = 0;
            int defensePenalty = 0;

            // Проверяем пороги от самого низкого к высокому (else if — заменяем)
            if (healthPercent < 0.1f)      // < 10%
            {
                speed = 0.35f;
                regen = 3;
                defensePenalty = 20;
            }
            else if (healthPercent < 0.3f) // < 30%
            {
                speed = 0.25f;
                regen = 2;
                defensePenalty = 15;
            }
            else if (healthPercent < 0.5f) // < 50%
            {
                speed = 0.15f;
                regen = 1;
                defensePenalty = 10;
            }

            // Записываем в ModPlayer — они применятся в его Update
            modPlayer.SpeedBonus = speed;
            modPlayer.LifeRegenBonus = regen;
            modPlayer.DefensePenalty = defensePenalty;
        }
    }
}