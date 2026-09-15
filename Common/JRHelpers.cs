using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Common
{
    public static class JRHelpers
    {
        public static void SetDebuffImmunity(int npcType, params int[] buffs)
        {
            foreach (int buff in buffs)
                NPCID.Sets.SpecificDebuffImmunity[npcType][buff] = true;
        }

        public static bool IsGoblin(NPC npc)
        {
            if (npc == null || !npc.active)
                return false;

            if (NPCID.Sets.BelongsToInvasionGoblinArmy[npc.type])
                return true;

            return npc.type is NPCID.GoblinPeon or NPCID.GoblinThief or NPCID.GoblinWarrior
                or NPCID.GoblinSorcerer or NPCID.GoblinArcher or NPCID.GoblinSummoner
                or NPCID.GoblinScout;
        }

        public static bool IsTrapHurt(Player.HurtInfo info)
        {
            if (info.DamageSource.SourceProjectileLocalIndex >= 0 && info.DamageSource.SourceProjectileLocalIndex < Main.maxProjectiles)
            {
                Projectile proj = Main.projectile[info.DamageSource.SourceProjectileLocalIndex];
                if (proj.active && proj.trap)
                    return true;
            }

            return false;
        }
    }
}
