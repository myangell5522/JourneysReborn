using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class WeaponImbue_Frostbite : ModBuff
    {
        public override void SetStaticDefaults()
        {
            BuffID.Sets.IsAFlaskBuff[Type] = true;
            Main.meleeBuff[Type] = true;
            Main.persistentBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            FlaskImbuePlayer imbuePlayer = player.GetModPlayer<FlaskImbuePlayer>();
            imbuePlayer.ImbueDebuffType = BuffID.Frostburn2;
            imbuePlayer.ImbueDustType = DustID.IceTorch;
            player.MeleeEnchantActive = true;
        }
    }
}
