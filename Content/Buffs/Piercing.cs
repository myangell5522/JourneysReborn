using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Piercing : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetArmorPenetration(DamageClass.Generic) += 10;
        }
    }
}
