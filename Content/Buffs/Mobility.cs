using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Mobility : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MobilityPlayer>().mobility = true;
        }
    }

    public class MobilityPlayer : ModPlayer
    {
        public bool mobility;

        public override void ResetEffects()
        {
            mobility = false;
        }

        public override void PostUpdateRunSpeeds()
        {
            if (!mobility)
                return;

            Player.maxRunSpeed *= 1.10f;
            Player.accRunSpeed *= 1.10f;
            Player.runAcceleration *= 1.25f;
            Player.runSlowdown *= 1.25f;
        }
    }
}
