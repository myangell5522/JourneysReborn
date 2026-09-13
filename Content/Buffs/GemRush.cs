using Microsoft.Xna.Framework;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class GemRushAmber : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.25f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushAmethyst : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.15f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushDiamond : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.25f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushEmerald : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.2f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushRuby : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.25f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushSapphire : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.2f;
        }
    }
}

namespace JourneysReborn.Content.Buffs
{
    public class GemRushTopaz : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.15f;
        }
    }
}