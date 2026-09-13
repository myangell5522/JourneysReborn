using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
	public class Resistance : ModBuff
	{
		public override void SetStaticDefaults() {
            Main.buffNoSave[Type] = false;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.noKnockback = true;
        }
    }
}