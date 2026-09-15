using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class WeaponImbue_Hellfire : ModBuff
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
            imbuePlayer.ImbueDebuffType = BuffID.OnFire3;
            imbuePlayer.ImbueDustType = DustID.Torch;
            player.MeleeEnchantActive = true;
        }
    }
}
