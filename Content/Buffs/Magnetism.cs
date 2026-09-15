using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Magnetism : ModBuff
    {
        public const int ExtraPickupTiles = 5;

        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MagnetismPlayer>().magnetism = true;
        }
    }

    public class MagnetismPlayer : ModPlayer
    {
        public bool magnetism;

        public override void ResetEffects()
        {
            magnetism = false;
        }
    }

    public class MagnetismItemGrab : GlobalItem
    {
        public override void GrabRange(Item item, Player player, ref int grabRange)
        {
            if (player.GetModPlayer<MagnetismPlayer>().magnetism)
                grabRange += Magnetism.ExtraPickupTiles * 16;
        }
    }
}
