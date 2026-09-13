using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Grounded : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = false;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GroundedDebuffPlayer>().grounded = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<GroundedDebuffNPC>().grounded = true;
        }
    }

    public class GroundedDebuffPlayer : ModPlayer
    {
        public bool grounded;
        public override void ResetEffects()
        {
            grounded = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if(grounded && !Collision.SolidTiles(Player.position, Player.width, (int)(Player.height * 1.2))) {
                if(Player.lifeRegen > 0) Player.lifeRegen = 0;
                Player.lifeRegenTime = 0;
                Player.lifeRegen -= 64;
                if(Main.rand.NextBool(2, 5))
                    Dust.NewDust(Player.position, 2, 2, DustID.Electric, Main.rand.NextFloat(-0.75f, 0.75f), Main.rand.NextFloat(-0.15f, 0.15f), 0, Color.GhostWhite);
            };
        }
    }
    public class GroundedDebuffNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool grounded;
        public override void ResetEffects(NPC npc)
        {
            grounded = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if(grounded && !Collision.SolidTiles(npc.position, npc.width, (int)(npc.height * 1.2))) {
                if(npc.lifeRegen > 0) npc.lifeRegen = 0;
                npc.lifeRegen -= 64;
                if(Main.rand.NextBool(2, 5))
                    Dust.NewDust(npc.position, 2, 2, DustID.Electric, Main.rand.NextFloat(-0.75f, 0.75f), Main.rand.NextFloat(-0.15f, 0.15f), 0, Color.GhostWhite);
            };
        }
    }
}