using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.NPCs
{
    //internal class NPCExtraInfo : GlobalNPC
    //{
        //public override bool InstancePerEntity => true;

        //public int heartCrystalsConsumed = 0;
        //public bool isAppliedAvaritia = false;
        //public NPC spawnerNPC = null;
        //public List<NPC> childNPCs = new List<NPC>();
        //public bool isRevived = false;
        //public List<int> reviveCandidates = new List<int>();
        //public List<Vector2> revivePositions = new List<Vector2>();
        //public bool isAnyQuestActive = false;
        //public bool isAnyQuestFinished = false;
        //public Vector2[] additionalVectors = {Vector2.Zero, Vector2.Zero, Vector2.Zero};

        //public override void OnSpawn(NPC npc, IEntitySource source)
        //{
            //if(source is EntitySource_Parent parent_Source && parent_Source.Entity is NPC parent_spawner) {
                //npc.GetGlobalNPC<NPCExtraInfo>().spawnerNPC = parent_spawner;
                //parent_spawner.GetGlobalNPC<NPCExtraInfo>().childNPCs.Add(npc);
            //};
        //}
    //}

    internal class NPCStatuses : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public int rampageNPCType;
        public bool isCorrupt;
		public bool isCorruptExtended;
        public bool isCrimson;
		public bool isCrimsonExtended;
        public bool isHallowed;
		public bool isHallowedExtended;
        public bool isUnderworld;
		public bool isUnderworldExtended;
        public bool isUnderworldDemon;
        public bool isMimic;
		public bool isTechnological;
        // public bool isZombieLike;
        // public bool isDefaultSkeletonLike;
        // public bool isDungeonSkeletonDefaultLike;
        // public bool isDungeonSkeletonSpecialLike;

        public override void SetDefaults(NPC npc)
        {
            if(npc.type == NPCID.EaterofSouls || npc.type == NPCID.LittleEater || npc.type == NPCID.BigEater || npc.type == NPCID.CorruptBunny || npc.type == NPCID.CorruptPenguin ||
                npc.type == NPCID.CorruptGoldfish || npc.type == NPCID.Corruptor || npc.type == NPCID.CorruptSlime ||
                npc.type == NPCID.DevourerHead || npc.type == NPCID.DevourerBody || npc.type == NPCID.DevourerTail ||
                npc.type == NPCID.CorruptSlime || npc.type == NPCID.Slimeling || npc.type == NPCID.Slimer ||
                npc.type == NPCID.Slimer2 || npc.type == NPCID.SeekerHead || npc.type == NPCID.SeekerBody ||
                npc.type == NPCID.SeekerTail || npc.type == NPCID.CursedHammer || npc.type == NPCID.Clinger ||
                npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.DesertGhoulCorruption ||
                npc.type == NPCID.PigronCorruption || npc.type == NPCID.DarkMummy) {
                    isCorrupt = true;
            };
			if(npc.type == NPCID.EaterofSouls || npc.type == NPCID.LittleEater || npc.type == NPCID.BigEater || npc.type == NPCID.CorruptBunny || npc.type == NPCID.CorruptPenguin ||
                npc.type == NPCID.CorruptGoldfish || npc.type == NPCID.Corruptor || npc.type == NPCID.CorruptSlime ||
                npc.type == NPCID.DevourerHead || npc.type == NPCID.DevourerBody || npc.type == NPCID.DevourerTail ||
                npc.type == NPCID.CorruptSlime || npc.type == NPCID.Slimeling || npc.type == NPCID.Slimer ||
                npc.type == NPCID.Slimer2 || npc.type == NPCID.SeekerHead || npc.type == NPCID.SeekerBody ||
                npc.type == NPCID.SeekerTail || npc.type == NPCID.CursedHammer || npc.type == NPCID.Clinger ||
                npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.DesertGhoulCorruption ||
                npc.type == NPCID.PigronCorruption || npc.type == NPCID.DarkMummy || npc.type == NPCID.EaterofWorldsHead || npc.type == NPCID.EaterofWorldsBody || npc.type == NPCID.EaterofWorldsTail) {
                    isCorruptExtended = true;
			};
            if(npc.type == NPCID.BloodCrawler || npc.type == NPCID.BloodCrawlerWall || npc.type == NPCID.CrimsonGoldfish || npc.type == NPCID.CrimsonBunny || npc.type == NPCID.CrimsonPenguin ||
                npc.type == NPCID.FaceMonster || npc.type == NPCID.Crimera || npc.type == NPCID.BigCrimera ||
                npc.type == NPCID.LittleCrimera || npc.type == NPCID.Herpling || npc.type == NPCID.BloodJelly ||
                npc.type == NPCID.BigCrimslime || npc.type == NPCID.Crimslime || npc.type == NPCID.BloodFeeder ||
                npc.type == NPCID.BloodMummy || npc.type == NPCID.CrimsonAxe || npc.type == NPCID.IchorSticker ||
                npc.type == NPCID.FloatyGross || npc.type == NPCID.BigMimicCrimson || npc.type == NPCID.PigronCrimson ||
                npc.type == NPCID.DesertGhoulCrimson) {
                    isCrimson = true;
            };
			if(npc.type == NPCID.BloodCrawler || npc.type == NPCID.BloodCrawlerWall || npc.type == NPCID.CrimsonGoldfish || npc.type == NPCID.CrimsonBunny || npc.type == NPCID.CrimsonPenguin ||
                npc.type == NPCID.FaceMonster || npc.type == NPCID.Crimera || npc.type == NPCID.BigCrimera ||
                npc.type == NPCID.LittleCrimera || npc.type == NPCID.Herpling || npc.type == NPCID.BloodJelly ||
                npc.type == NPCID.BigCrimslime || npc.type == NPCID.Crimslime || npc.type == NPCID.BloodFeeder ||
                npc.type == NPCID.BloodMummy || npc.type == NPCID.CrimsonAxe || npc.type == NPCID.IchorSticker ||
                npc.type == NPCID.FloatyGross || npc.type == NPCID.BigMimicCrimson || npc.type == NPCID.PigronCrimson ||
                npc.type == NPCID.DesertGhoulCrimson || npc.type == NPCID.BrainofCthulhu || npc.type == NPCID.Creeper) {
                    isCrimsonExtended = true;
            };
            if(npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.RainbowSlime ||
                npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy || npc.type == NPCID.IlluminantSlime ||
                npc.type == NPCID.IlluminantBat || npc.type == NPCID.ChaosElemental || npc.type == NPCID.EnchantedSword ||
                npc.type == NPCID.BigMimicHallow || npc.type == NPCID.PigronHallow || npc.type == NPCID.DesertGhoulHallow) {
                    isHallowed = true;
            };
			if(npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.RainbowSlime ||
                npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy || npc.type == NPCID.IlluminantSlime ||
                npc.type == NPCID.IlluminantBat || npc.type == NPCID.ChaosElemental || npc.type == NPCID.EnchantedSword ||
                npc.type == NPCID.BigMimicHallow || npc.type == NPCID.PigronHallow || npc.type == NPCID.DesertGhoulHallow || 
				npc.type == NPCID.QueenSlimeBoss || npc.type == NPCID.QueenSlimeMinionBlue || npc.type == NPCID.QueenSlimeMinionPink || npc.type == NPCID.QueenSlimeMinionPurple || npc.type == NPCID.HallowBoss) {
                    isHallowedExtended = true;
            };
            if(npc.type == NPCID.Hellbat || npc.type == NPCID.LavaSlime || npc.type == NPCID.FireImp || npc.type == NPCID.Demon ||
                npc.type == NPCID.VoodooDemon || npc.type == NPCID.BoneSerpentBody || npc.type == NPCID.BoneSerpentHead ||
                npc.type == NPCID.BoneSerpentTail || npc.type == NPCID.DemonTaxCollector || npc.type == NPCID.Lavabat ||
                npc.type == NPCID.RedDevil) {
                    isUnderworld = true;
            };
			if(npc.type == NPCID.Hellbat || npc.type == NPCID.LavaSlime || npc.type == NPCID.FireImp || npc.type == NPCID.Demon ||
                npc.type == NPCID.VoodooDemon || npc.type == NPCID.BoneSerpentBody || npc.type == NPCID.BoneSerpentHead ||
                npc.type == NPCID.BoneSerpentTail || npc.type == NPCID.DemonTaxCollector || npc.type == NPCID.Lavabat || npc.type == NPCID.RedDevil ||
				npc.type == NPCID.WallofFlesh || npc.type == NPCID.WallofFleshEye || npc.type == NPCID.TheHungry || npc.type == NPCID.TheHungryII || npc.type == NPCID.LeechHead || npc.type == NPCID.LeechBody || npc.type == NPCID.LeechTail ) {
                    isUnderworldExtended = true;
            };
            if(npc.type == NPCID.Demon || npc.type == NPCID.VoodooDemon || npc.type == NPCID.DemonTaxCollector ||
                npc.type == NPCID.RedDevil) {
                    isUnderworldDemon = true;
            };
            if(npc.type == NPCID.Mimic || npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.BigMimicCrimson ||
                npc.type == NPCID.BigMimicHallow || npc.type == NPCID.BigMimicJungle || npc.type == NPCID.IceMimic ||
                npc.type == NPCID.PresentMimic) {
                    isMimic = true;
            };
            if(npc.type == NPCID.MartianProbe || npc.type == NPCID.DeadlySphere || npc.type == NPCID.BrainScrambler ||
                npc.type == NPCID.GigaZapper || npc.type == NPCID.GrayGrunt || npc.type == NPCID.MartianDrone ||
                npc.type == NPCID.MartianEngineer || npc.type == NPCID.MartianOfficer || npc.type == NPCID.MartianWalker ||
                npc.type == NPCID.RayGunner || npc.type == NPCID.ScutlixRider || npc.type == NPCID.MartianTurret ||
                npc.type == NPCID.ElfCopter || npc.type == NPCID.SkeletronPrime || npc.type == NPCID.PrimeCannon ||
                npc.type == NPCID.PrimeLaser || npc.type == NPCID.PrimeSaw || npc.type == NPCID.PrimeVice ||
                npc.type == NPCID.TheDestroyer || npc.type == NPCID.TheDestroyerBody || npc.type == NPCID.TheDestroyerTail ||
                npc.type == NPCID.Spazmatism || npc.type == NPCID.Retinazer || npc.type == NPCID.SantaNK1 || npc.type == NPCID.Probe ||
                npc.type == NPCID.MartianSaucer || npc.type == NPCID.MartianSaucerCannon || npc.type == NPCID.MartianSaucerCore ||
                npc.type == NPCID.MartianSaucerTurret) {
                    isTechnological = true;
            };
        }
    }

    //internal class ProjectileStatusesAndInfo : GlobalProjectile
    //{
        //public override bool InstancePerEntity => true;
        //public NPC spawnerNPC = null;
        //public NPC homingTarget = null;

        //public override void OnSpawn(Projectile projectile, IEntitySource source)
        //{
            //if(source is EntitySource_Parent parent_Source && parent_Source.Entity is NPC parent_spawner) {
                //projectile.GetGlobalProjectile<ProjectileStatusesAndInfo>().spawnerNPC = parent_spawner;
            //};
        //}
    //}

    //internal class PlayerStatusesAndInfo : ModPlayer
    //{
        //public NPC lastHitter = null;
        //public Player.HurtInfo lastHitInfo;
        //public bool shouldGelatineShieldActivate = false;
    //}
}