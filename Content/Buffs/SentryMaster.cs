using Terraria;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
	public class SentryMaster : ModBuff
	{
		public override void SetStaticDefaults() {
			Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = false;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.maxTurrets += 1;
        }
    
	}
}