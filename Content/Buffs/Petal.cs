using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs 
{
    public class Petal : ModBuff
    {
        public override void SetStaticDefaults() {
			Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = false;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetArmorPenetration(DamageClass.Generic) += 10;
        }
    }
}