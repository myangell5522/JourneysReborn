using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Providence : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<ProvidenceDebuff>().providence = true;
        }
    }

    public class ProvidenceDebuff : ModPlayer
    {
        public bool providence;
        public override void ResetEffects() {
			providence = false;
		}

        public override bool CanUseItem(Item item)
        {
            if(providence) {
                if(item.type == ItemID.RodofDiscord || item.type == ItemID.RodOfHarmony)
                    return false;
            };
            return base.CanUseItem(item);
        }
    }
}