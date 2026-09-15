using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
    public class PhantomDecay : ModBuff
    {
        public const int Duration = 300;

        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PhantomDecayPlayer>().phantomDecay = true;
        }
    }

    public class PhantomDecayPlayer : ModPlayer
    {
        public bool phantomDecay;

        public override void ResetEffects()
        {
            phantomDecay = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (!phantomDecay)
                return;

            Player.statMana -= 1;
            if (Player.statMana < 0)
                Player.statMana = 0;

            Player.manaRegenDelay = Player.maxRegenDelay;
            Player.manaRegen = 0;

            if (Main.rand.NextBool(4))
                Dust.NewDust(Player.position, Player.width, Player.height, DustID.DungeonSpirit, 0f, -0.4f, 150);
        }
    }

    public class PhantomDecayNPC : GlobalNPC
    {
        public override void OnHitPlayer(NPC npc, Player target, Player.HurtInfo hurtInfo)
        {
            if (npc.type == NPCID.DungeonSpirit)
                target.AddBuff(ModContent.BuffType<PhantomDecay>(), PhantomDecay.Duration);
        }
    }
}
