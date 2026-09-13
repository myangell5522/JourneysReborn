using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class Overweight : ModBuff
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
            player.GetModPlayer<OverweightDebuffPlayer>().overweighted = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<OverweightDebuffNPC>().overweighted = true;
        }
    }
    public class OverweightDebuffPlayer : ModPlayer
    {
        public bool overweighted;
        public override void ResetEffects()
        {
            overweighted = false;
        }
        public override void PreUpdateMovement()
        {
            if(overweighted)  Player.velocity.Y += 0.1f;
        }
    }
    public class OverweightDebuffNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool overweighted;
        public override void ResetEffects(NPC npc)
        {
            overweighted = false;
        }

        public override void AI(NPC npc)
        {
            if(overweighted) {
                npc.velocity.Y += npc.noTileCollide ? 0.05f : 0.1f;
            };
        }
    }

    public class OverweightInflicterPlayer : ModPlayer
    {
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if(item.type == ItemID.TitaniumSword) target.AddBuff(ModContent.BuffType<Overweight>(), 300);
        }
    }
}