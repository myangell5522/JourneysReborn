using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace JourneysReborn.NPCs
{
	public class DropsRework : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
		if(npc.type == NPCID.AngryBones || npc.type == NPCID.BigBoned || npc.type == NPCID.ShortBones || npc.type == NPCID.AngryBonesBig || npc.type == NPCID.AngryBonesBigMuscle || npc.type == NPCID.AngryBonesBigHelmet || npc.type == NPCID.HeavySkeleton || npc.type == NPCID.ArmoredSkeleton || npc.type == NPCID.GiantCursedSkull || npc.type == NPCID.CursedSkull || npc.type == NPCID.GreekSkeleton || npc.type == NPCID.SkeletonArcher || npc.type == NPCID.DarkCaster || npc.type == NPCID.RustyArmoredBonesFlail || npc.type == NPCID.RustyArmoredBonesAxe || npc.type == NPCID.RustyArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesSwordNoArmor || npc.type == NPCID.BlueArmoredBones || npc.type == NPCID.BlueArmoredBonesMace || npc.type == NPCID.BlueArmoredBonesNoPants || npc.type == NPCID.BlueArmoredBonesSword || npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword) {
				npcLoot.Add(ItemDropRule.Common(ItemID.MilkCarton, 200));
			};
			if(npc.type == NPCID.AngryBones || npc.type == NPCID.BigBoned || npc.type == NPCID.ShortBones || npc.type == NPCID.AngryBonesBig || npc.type == NPCID.AngryBonesBigMuscle || npc.type == NPCID.AngryBonesBigHelmet ||  npc.type == NPCID.GiantCursedSkull || npc.type == NPCID.CursedSkull || npc.type == NPCID.DarkCaster || npc.type == NPCID.RustyArmoredBonesFlail || npc.type == NPCID.RustyArmoredBonesAxe || npc.type == NPCID.RustyArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesSwordNoArmor || npc.type == NPCID.BlueArmoredBones || npc.type == NPCID.BlueArmoredBonesMace || npc.type == NPCID.BlueArmoredBonesNoPants || npc.type == NPCID.BlueArmoredBonesSword || npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword) {
				npcLoot.Add(ItemDropRule.OneFromOptions(150, ItemID.SkellingtonJSkellingsworth, ItemID.BoneWarp, ItemID.Catacomb));
			};
			if(npc.type == NPCID.AngryNimbus) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Cloud, 1, 1, 4));
				npcLoot.Add(ItemDropRule.Common(ItemID.RainCloud, 1, 1, 4));
				npcLoot.Add(ItemDropRule.Common(ItemID.Thunderbolt, 40));
			};
			if(npc.type == NPCID.AngryTrapper) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Vine, 2));
			}; 
			if(npc.type == NPCID.AnomuraFungus || npc.type == NPCID.MushiLadybug || npc.type == NPCID.FungoFish || npc.type == NPCID.FungiBulb || npc.type == NPCID.GiantFungiBulb || npc.type == NPCID.SporeBat || npc.type == NPCID.ZombieMushroom || npc.type == NPCID.ZombieMushroomHat || npc.type == NPCID.SporeSkeleton) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.Bioluminescence, 150));
			};
			if(npc.type == NPCID.Antlion) {
				npcLoot.Add(ItemDropRule.Common(ItemID.JawsOfDeath, 100));
			};
			if(npc.type == NPCID.ArmoredViking || npc.type == NPCID.UndeadViking || npc.type == NPCID.DiabolistRed || npc.type == NPCID.DiabolistWhite || npc.type == NPCID.NecromancerArmored || npc.type == NPCID.Necromancer || npc.type == NPCID.TacticalSkeleton || npc.type == NPCID.SkeletonCommando || npc.type == NPCID.SkeletonSniper || npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat) {
				npcLoot.Add(ItemDropRule.Food(ItemID.MilkCarton, 100));
			};
			if(npc.type == NPCID.Antlion) {
				npcLoot.Add(ItemDropRule.Common(ItemID.JawsOfDeath, 100));
			};
			if(npc.type == NPCID.ArmoredViking || npc.type == NPCID.UndeadViking) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.VikingVoyage, 66));
			};
			if(npc.type == NPCID.BestiaryGirl) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.ShiningMoon, 10));
			};
			if(npc.type == NPCID.BigMimicHallow) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.Impact, 8));
			};
			if(npc.type == NPCID.BloodCrawler || npc.type == NPCID.BloodCrawlerWall || npc.type == NPCID.LittleCrimera || npc.type == NPCID.BigCrimera || npc.type == NPCID.Crimera || npc.type == NPCID.Herpling) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.DeadlandComesAlive, 100));
			};
			if(npc.type == NPCID.BloodMummy || npc.type == NPCID.DarkMummy || npc.type == NPCID.LightMummy) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(150, ItemID.Duality, ItemID.BandageBoy));
			};
			if(npc.type == NPCID.BloodNautilus) {
				npcLoot.Add(ItemDropRule.Common(ItemID.DreadoftheRedSea, 10));
		    };
			if(npc.type == NPCID.BloodZombie || npc.type == NPCID.Drippler) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.BloodMoonRising, ItemID.BloodyGoblet));
			};
			if(npc.type == NPCID.BlueSlime) {
				npcLoot.Add(ItemDropRule.Common(ItemID.FirstEncounter, 200));
		    };
			if(npc.type == NPCID.BoneLee) {		
			    npcLoot.Add(ItemDropRule.Food(ItemID.MilkCarton, 20));
			}; 
			if(npc.type == NPCID.BoneSerpentHead) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.Skelehead, 50));
			};
			if(npc.type == NPCID.BrainofCthulhu) {
				npcLoot.Add(ItemDropRule.Common(ItemID.FacingtheCerebralMastermind, 10));
			};		
			if(npc.type == NPCID.BrainScrambler || npc.type == NPCID.MartianOfficer || npc.type == NPCID.GrayGrunt || npc.type == NPCID.MartianEngineer || npc.type == NPCID.GigaZapper || npc.type == NPCID.ScutlixRider || npc.type == NPCID.Scutlix || npc.type == NPCID.MartianDrone || npc.type == NPCID.MartianWalker) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.PaintingMartiaLisa, 200));
			};
			if(npc.type == NPCID.CaveBat || npc.type == NPCID.GiantBat) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.UndergroundReward, 100));
			};
			if(npc.type == NPCID.Clown) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(20, ItemID.ChickenNugget, ItemID.Fries, ItemID.Burger));
			};
			if(npc.type == NPCID.CochinealBeetle || npc.type == NPCID.CyanBeetle || npc.type == NPCID.LacBeetle) {
				npcLoot.Add(ItemDropRule.Food(ItemID.PotatoChips, 15));
			};
			if(npc.type == NPCID.CorruptBunny || npc.type == NPCID.CrimsonBunny) {
				npcLoot.Add(ItemDropRule.Food(ItemID.BunnyStew, 20));
				npcLoot.Add(ItemDropRule.OneFromOptions(40, ItemID.BennyWarhol, ItemID.Constellation));
			};
			if(npc.type == NPCID.CorruptGoldfish || npc.type == NPCID.CrimsonGoldfish || npc.type == NPCID.Goldfish || npc.type == NPCID.GoldfishWalker || npc.type == NPCID.GoldGoldfish || npc.type == NPCID.GoldGoldfishWalker || npc.type == NPCID.BloodFeeder || npc.type == NPCID.BloodJelly || npc.type == NPCID.BlueJellyfish || npc.type == NPCID.GreenJellyfish || npc.type == NPCID.Piranha || npc.type == NPCID.AnglerFish || npc.type == NPCID.Arapaima) {
				npcLoot.Add(ItemDropRule.Common(ItemID.SilentFish, 40));
			};
			if(npc.type == NPCID.Corruptor) {
				npcLoot.Add(ItemDropRule.Food(ItemID.Burger, 75));
			};
			if(npc.type == NPCID.Crab) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Crustography, 33));
			};		
			if(npc.type == NPCID.CultistBoss) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.MoonmanandCompany, ItemID.RemnantsofDevotion));
			};			
			if(npc.type == NPCID.CultistDevote || npc.type == NPCID.CultistArcherBlue) {
				npcLoot.Add(ItemDropRule.Food(ItemID.RemnantsofDevotion, 40));
	        }; 
            if(npc.type == NPCID.Dandelion) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.GoodMorning, ItemID.Sunflowers, ItemID.Wildflowers));
			};			
			if(npc.type == NPCID.DarkCaster) {	
				npcLoot.Add(ItemDropRule.NormalvsExpert(ItemID.WaterBolt, 300, 150));
			};
			if(npc.type == NPCID.Deerclops) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.PaintingWilson, ItemID.PaintingWillow, ItemID.PaintingWendy, ItemID.PaintingWolfgang));
			};
			if(npc.type == NPCID.Demolitionist) {
				npcLoot.Add(ItemDropRule.Common(ItemID.AmericanExplosive, 10));
			};
	        if(npc.type == NPCID.Demon || npc.type == NPCID.VoodooDemon || npc.type == NPCID.RedDevil) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.DemonsEye, 66));
			}; 
			if(npc.type == NPCID.Demon || npc.type == NPCID.VoodooDemon) {		
			    npcLoot.Add(ItemDropRule.StatusImmunityItem(ItemID.Blindfold, 150));
			}; 
			if(npc.type == NPCID.DemonEye || npc.type == NPCID.DemonEye2 || npc.type == NPCID.PurpleEye2 || npc.type == NPCID.GreenEye2 || npc.type == NPCID.DialatedEye2 || npc.type == NPCID.SleepyEye2 || npc.type == NPCID.CataractEye2 || npc.type == NPCID.WanderingEye || npc.type == NPCID.CataractEye || npc.type == NPCID.SleepyEye || npc.type == NPCID.DialatedEye || npc.type == NPCID.GreenEye || npc.type == NPCID.PurpleEye || npc.type == NPCID.DemonEyeOwl || npc.type == NPCID.DemonEyeSpaceship) {	
			    npcLoot.Add(ItemDropRule.Common(ItemID.ThePersistencyofEyes, 150));
			};
			if(npc.type == NPCID.DesertBeast) {
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.PrehistoryPreserved, ItemID.AncientTablet));
			};
			if(npc.type == NPCID.DesertDjinn) {
				npcLoot.Add(ItemDropRule.Common(ItemID.BurningSpirit, 100));
			};
			if(npc.type == NPCID.DesertGhoul || npc.type == NPCID.DesertGhoulCorruption || npc.type == NPCID.DesertGhoulCrimson || npc.type == NPCID.DesertGhoulHallow) {		
			    npcLoot.Add(ItemDropRule.Food(ItemID.Nachos, 20));
			};
			if(npc.type == NPCID.DesertLamiaLight || npc.type == NPCID.DesertLamiaDark) {
				npcLoot.Add(ItemDropRule.Common(ItemID.SnakesIHateSnakes, 100));
		    };
			if(npc.type == NPCID.DesertScorpionWalk || npc.type == NPCID.DesertScorpionWall) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Stinger, 3, 1));
			};
			if(npc.type == NPCID.DoctorBones) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.BlandWhip, 3));
				npcLoot.Add(ItemDropRule.Common(ItemID.ZombieArm, 3));
				npcLoot.Add(ItemDropRule.Common(ItemID.Shackle, 2));
				npcLoot.Add(ItemDropRule.Common(ItemID.SpiffoPlush, 4));
				npcLoot.Add(ItemDropRule.Common(ItemID.Skull, 1));
				npcLoot.Add(ItemDropRule.Common(ItemID.GoldBar, 1, 5, 15));
			};
			if(npc.type == NPCID.DrManFly) {
				npcLoot.Add(ItemDropRule.Common(ItemID.AHorribleNightforAlchemy, 100));
			};
			if(npc.type == NPCID.Dryad) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.Dryadisque, 10));
			};
			if(npc.type == NPCID.DukeFishron) {	
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.Fangs, ItemID.WhatLurksBelow, ItemID.TheDuke)); 
			};
			if(npc.type == NPCID.DuneSplicerHead || npc.type == NPCID.TombCrawlerHead) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(66, ItemID.AndrewSphinx, ItemID.DivineEye));
			};
			if(npc.type == NPCID.DungeonSlime) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Gel, 1, 3, 8));
			};
			if(npc.type == NPCID.DyeTrader) {
				npcLoot.Add(ItemDropRule.Common(ItemID.StrangeGrowth, 10));
			};
			if(npc.type == NPCID.EaterofSouls || npc.type == NPCID.BigEater || npc.type == NPCID.LittleEater || npc.type == NPCID.DevourerHead) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.LightlessChasms, 100));
			};
			if(npc.type == NPCID.EyeofCthulhu) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.TheEyeSeestheEnd, ItemID.SomethingEvilisWatchingYou, ItemID.EvilPresence));
			};	
            if(npc.type == NPCID.FaceMonster) {
				npcLoot.Add(ItemDropRule.Common(ItemID.TheScreamer, 150));
	        };			
			if(npc.type == NPCID.FireImp) {
				npcLoot.Add(ItemDropRule.Common(ItemID.HellCake, 100));
				npcLoot.Add(ItemDropRule.Common(ItemID.ImpFace, 100));
			};
			if(npc.type == NPCID.Ghost) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(33, ItemID.TrappedGhost, ItemID.TheHangedMan));
			};
			if(npc.type == NPCID.GiantFlyingAntlion || npc.type == NPCID.FlyingAntlion) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(125, ItemID.Uluru, ItemID.LifeAboveTheSand));
			};
			if(npc.type == NPCID.GiantWalkingAntlion || npc.type == NPCID.WalkingAntlion) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.WatchfulAntlion, 125));
			};
			if(npc.type == NPCID.Gnome) {
				npcLoot.Add(ItemDropRule.OneFromOptions(20, ItemID.Purity, ItemID.HappyLittleTree, ItemID.ThroughtheWindow, ItemID.Daylight, ItemID.ForestTroll));
			};
			if(npc.type == NPCID.GoblinPeon || npc.type == NPCID.GoblinThief || npc.type == NPCID.GoblinWarrior || npc.type == NPCID.GoblinSorcerer || npc.type == NPCID.GoblinArcher) {	
			    npcLoot.Add(ItemDropRule.Common(ItemID.GoblinsPlayingPoker, 150));
			};
			if(npc.type == NPCID.GoblinScout) {		
			    npcLoot.Add(ItemDropRule.FewFromOptions(2, 5, ItemID.Secrets, ItemID.Outcast, ItemID.CrownoDevoursHisLunch, ItemID.KargohsSummon, ItemID.ParsecPals, ItemID.DoNotEattheVileMushroom, ItemID.SunshineofIsrapony, ItemID.HailtotheKing, ItemID.LadyOfTheLake, ItemID.PlacePainting));
				 npcLoot.Add(ItemDropRule.Common(ItemID.Waldo, 100));
			};
			if(npc.type == NPCID.GoblinSummoner) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.GoblinsPlayingPoker, 8));
			};
			if(npc.type == NPCID.GoblinTinkerer) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.TerrarianGothic, 10));
			};
			if(npc.type == NPCID.Golem) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.LihzahrdBrick, 1, 10, 40));
			};  
			if(npc.type == NPCID.Golfer || npc.type == NPCID.GolferRescue) {
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.GolfPainting1, ItemID.GolfPainting2, ItemID.GolfPainting3, ItemID.GolfPainting4));
			};	
			if(npc.type == NPCID.GreekSkeleton) {
				npcLoot.Add(ItemDropRule.Common(ItemID.HoplitePizza, 125));
			};
			if(npc.type == NPCID.Guide) {	
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.GuidePicasso, ItemID.TheCreationoftheGuide, ItemID.TrioSuperHeroes));
			};  
			if(npc.type == NPCID.HallowBoss) {
				npcLoot.Add(ItemDropRule.Common(ItemID.FairyGuides, 100));
			};
		    if(npc.type == NPCID.Harpy) {
				npcLoot.Add(ItemDropRule.OneFromOptions(66, ItemID.PlaceAbovetheClouds, ItemID.Discover, ItemID.SeeTheWorldForWhatItIs));
				npcLoot.Add(ItemDropRule.Common(ItemID.SunOrnament, 100));
			};
			if(npc.type == NPCID.Hellbat || npc.type == NPCID.Lavabat) {	
				npcLoot.Add(ItemDropRule.OneFromOptions(125, ItemID.Darkness, ItemID.HandEarth));
			};
			if(npc.type == NPCID.HoppinJack) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.BitterHarvest, 200)); 
			};
			if(npc.type == NPCID.IceBat) {
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.ColdWatersintheWhiteLand, ItemID.MorningHunt));
			};	
			if(npc.type == NPCID.IceSlime) {
				npcLoot.Add(ItemDropRule.Common(ItemID.BlizzardinaBottle, 200)); 
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.ColdWatersintheWhiteLand, ItemID.MorningHunt));
	        };
			if(npc.type == NPCID.IceQueen) {
				npcLoot.Add(ItemDropRule.Common(ItemID.PaintingColdSnap, 10));
		    };
			if(npc.type == NPCID.JungleBat || npc.type == NPCID.JungleSlime || npc.type == NPCID.GiantFlyingFox || npc.type == NPCID.Derpling) {
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.DoNotStepontheGrass, ItemID.Heartlands));
	        };
			if(npc.type == NPCID.JungleCreeperWall || npc.type == NPCID.JungleCreeper) {
				npcLoot.Add(ItemDropRule.Food(ItemID.FriedEgg, 30));
				npcLoot.Add(ItemDropRule.Common(ItemID.SpiderFang, 2));
			};
			if(npc.type == NPCID.KingSlime) {
				npcLoot.Add(ItemDropRule.Common(ItemID.RoyalRomance, 10));
			};
			if(npc.type == NPCID.LavaSlime) {
				npcLoot.Add(ItemDropRule.OneFromOptions(125, ItemID.LakeofFire, ItemID.FlowingMagma, ItemID.GloryoftheFire));
	        };
			if(npc.type == NPCID.Lihzahrd || npc.type == NPCID.LihzahrdCrawler) {
				npcLoot.Add(ItemDropRule.Common(ItemID.LizardKing, 100));
			};
			if(npc.type == NPCID.LostGirl || npc.type == NPCID.Nymph) {
				npcLoot.Add(ItemDropRule.Food(ItemID.ChocolateChipCookie, 3));
	        }; 
			if(npc.type == NPCID.MartianSaucerCore || npc.type == NPCID.MartianProbe) {
				npcLoot.Add(ItemDropRule.Common(ItemID.PaintingTheTruthIsUpThere, 10));
		    };
			if(npc.type == NPCID.MartianTurret) {
				npcLoot.Add(ItemDropRule.Common(ItemID.PoweredbyBirds, 50));
	        };
			if(npc.type == NPCID.MaggotZombie) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.Shackle, 50));
				npcLoot.Add(ItemDropRule.NormalvsExpert(ItemID.ZombieArm, 400, 200));
				npcLoot.Add(ItemDropRule.Common(ItemID.SpiffoPlush, 1500));
				npcLoot.Add(ItemDropRule.OneFromOptions(50, ItemID.Graveyard, ItemID.Reborn));
			};
			if(npc.type == NPCID.Mechanic) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.TerrarianGothic, ItemID.HallowsEve));
			};
			if(npc.type == NPCID.Merchant) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.FatherofSomeone, ItemID.TheMerchant));
			};	
			if(npc.type == NPCID.MeteorHead) {
				npcLoot.Add(ItemDropRule.Common(ItemID.BlessingfromTheHeavens, 100));
	        };
			if(npc.type == NPCID.MisterStabby || npc.type == NPCID.SnowmanGangsta || npc.type == NPCID.SnowBalla) {
				npcLoot.Add(ItemDropRule.OneFromOptions(100, ItemID.PaintingAcorns, ItemID.PaintingSnowfellas, ItemID.PaintingTheSeason));
			};
			if(npc.type == NPCID.MoonLordCore) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.MoonLordPainting, ItemID.CatSword));
			};
			if(npc.type == NPCID.Mothron) {
				npcLoot.Add(ItemDropRule.Common(ItemID.TerraBladeChronicles, 66));
			};
			if(npc.type == NPCID.Mummy) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.BandageBoy, 150));
			};
			if(npc.type == NPCID.Nurse) {
				npcLoot.Add(ItemDropRule.Common(ItemID.NurseLisa, 10));
			};	
			if(npc.type == NPCID.Parrot) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Feather, 8));
			};
			if(npc.type == NPCID.PartyGirl) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.UnicornCrossingtheHallows, 10));
			};
			if(npc.type == NPCID.PirateCaptain) {
				npcLoot.Add(ItemDropRule.Common(ItemID.PillaginMePixels, 40));
			};
			if(npc.type == NPCID.PirateShip) {
				npcLoot.Add(ItemDropRule.Common(ItemID.PillaginMePixels, 20));
			};
			if(npc.type == NPCID.Pixie || npc.type == NPCID.Gastropod) {
				npcLoot.Add(ItemDropRule.Common(ItemID.TheLandofDeceivingLooks, 100));
			};
			if(npc.type == NPCID.Poltergeist) {
				npcLoot.Add(ItemDropRule.Common(ItemID.GhostManifestation, 100));
			};
			if(npc.type == NPCID.PossessedArmor) {
				npcLoot.Add(ItemDropRule.StatusImmunityItem(ItemID.ArmorPolish, 250));
			};
			if(npc.type == NPCID.Princess) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.PrincessStyle, ItemID.Princess64, ItemID.PaintingOfALass));
			};	
			if(npc.type == NPCID.QueenSlimeBoss) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.SuspiciouslySparkly, ItemID.RoyalRomance));
			};
			if(npc.type == NPCID.RainbowSlime) {
				npcLoot.Add(ItemDropRule.OneFromOptions(20, ItemID.TheLandofDeceivingLooks, ItemID.Bifrost));
			};
			if(npc.type == NPCID.Raven) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Nevermore, 50));
			};
			if(npc.type == NPCID.RayGunner) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.PaintingCastleMarsberg, 200)); 
			};
			if(npc.type == NPCID.Reaper) {
				npcLoot.Add(ItemDropRule.OneFromOptions(66, ItemID.DarkSoulReaper, ItemID.OminousPresence));
			};	
			if(npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism) {
				npcLoot.Add(ItemDropRule.Common(ItemID.TheTwinsHaveAwoken, 10));
			};
			if(npc.type == NPCID.RuneWizard) {
				npcLoot.Add(ItemDropRule.Common(ItemID.CursedFlame, 1, 3, 8));
				npcLoot.Add(ItemDropRule.Common(ItemID.Ichor, 1, 3, 8));
				npcLoot.Add(ItemDropRule.Common(ItemID.GreaterManaPotion, 1, 10, 20));
				npcLoot.Add(ItemDropRule.Food(ItemID.MilkCarton, 2));
				npcLoot.Add(ItemDropRule.Common(ItemID.SufficientlyAdvanced, 2));
			};
			if(npc.type == NPCID.SandsharkCorrupt) {
				npcLoot.Add(ItemDropRule.Common(ItemID.RottenChunk, 4, 1, 2));
			};
			if(npc.type == NPCID.SandsharkCrimson) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.Vertebrae, 4, 1, 2));
			};	
			if(npc.type == NPCID.SandSlime) {
				npcLoot.Add(ItemDropRule.Common(ItemID.SandstorminaBottle, 300));
                npcLoot.Add(ItemDropRule.Common(ItemID.TheSandsOfSlime, 100));				
			};
			if(npc.type == NPCID.SeekerHead) {	
				npcLoot.Add(ItemDropRule.Common(ItemID.WormTooth, 1, 3, 8));
			};
			if(npc.type == NPCID.Shark || npc.type == NPCID.PinkJellyfish || npc.type == NPCID.SeaSnail || npc.type == NPCID.Squid) {
				npcLoot.Add(ItemDropRule.OneFromOptions(25, ItemID.GreatWave, ItemID.NotSoLostInParadise, ItemID.CouchGag, ItemID.SilentFish));
			};
			if(npc.type == NPCID.Skeleton || npc.type == NPCID.SkeletonAlien || npc.type == NPCID.SkeletonAstonaut || npc.type == NPCID.SkeletonTopHat || npc.type == NPCID.BigSkeleton || npc.type == NPCID.SmallSkeleton || npc.type == NPCID.HeadacheSkeleton || npc.type == NPCID.PantlessSkeleton || npc.type == NPCID.BigPantlessSkeleton || npc.type == NPCID.BoneThrowingSkeleton || npc.type == NPCID.BoneThrowingSkeleton2 || npc.type == NPCID.BoneThrowingSkeleton3 || npc.type == NPCID.BoneThrowingSkeleton4 || npc.type == NPCID.MisassembledSkeleton || npc.type == NPCID.SmallHeadacheSkeleton || npc.type == NPCID.SmallPantlessSkeleton || npc.type == NPCID.ArmoredSkeleton || npc.type == NPCID.HeavySkeleton || npc.type == NPCID.SkeletonArcher) {	
				npcLoot.Add(ItemDropRule.OneFromOptions(150, ItemID.MorbidCuriosity, ItemID.WickedUndead, ItemID.StillLife));
			};
			if(npc.type == NPCID.SkeletonMerchant) {		
			    npcLoot.Add(ItemDropRule.Food(ItemID.MilkCarton, 5));
			};
			if(npc.type == NPCID.SkeletronHead) {
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.JackingSkeletron, ItemID.PaintingCursedSaint, ItemID.TheGuardiansGaze, ItemID.TheCursedMan)); 
		    };
			if(npc.type == NPCID.Snatcher) {
				npcLoot.Add(ItemDropRule.Common(ItemID.Vine, 4));
			};
            if(npc.type == NPCID.SpikedIceSlime) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.BlizzardinaBottle, 200));
			};
			if(npc.type == NPCID.SpikedJungleSlime) {
				npcLoot.Add(ItemDropRule.StatusImmunityItem(ItemID.Bezoar, 300));
			};
			if(npc.type == NPCID.Stylist || npc.type == NPCID.WebbedStylist) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.PrincessStyle, 10));
			};
			if(npc.type == NPCID.TheDestroyer) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.TheDestroyer, 10));
			};
			if(npc.type == NPCID.Tim) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.Robe, 1));
				npcLoot.Add(ItemDropRule.Common(ItemID.ManaCrystal, 1, 2, 5));
				npcLoot.Add(ItemDropRule.Common(ItemID.GreaterManaPotion, 1, 5, 10)); 
				npcLoot.Add(ItemDropRule.Common(ItemID.MilkCarton, 2));
				npcLoot.Add(ItemDropRule.Common(ItemID.RareEnchantment, 2));
			};
			if(npc.type == NPCID.TravellingMerchant) {
				npcLoot.Add(ItemDropRule.Common(ItemID.VisitingThePyramids, 10));
			};
			if(npc.type == NPCID.Truffle) {
				npcLoot.Add(ItemDropRule.Common(ItemID.MySon, 10));
			};
			if(npc.type == NPCID.Tumbleweed) {
				npcLoot.Add(ItemDropRule.Common(ItemID.SecretoftheSands, 66));
			};
			if(npc.type == NPCID.VampireBat || npc.type == NPCID.Vampire) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.BloodMoonCountess, 100));
			};
			if(npc.type == NPCID.Vulture) {
				npcLoot.Add(ItemDropRule.Food(ItemID.ChickenNugget, 150));
				npcLoot.Add(ItemDropRule.Common(ItemID.Oasis, 100));
			};
            if(npc.type == NPCID.UndeadMiner) {
                npcLoot.Add(ItemDropRule.Food(ItemID.MilkCarton, 50));
				npcLoot.Add(ItemDropRule.OneFromOptions(10, ItemID.TreasureMagnet, ItemID.MetalDetector));
                npcLoot.Add(ItemDropRule.OneFromOptions(20, ItemID.StrangeDeadFellows, ItemID.FindingGold, ItemID.OldMiner));				
            };			
			if(npc.type == NPCID.Unicorn) {
				npcLoot.Add(ItemDropRule.Common(ItemID.LuckyHorseshoe, 50));
				npcLoot.Add(ItemDropRule.Common(ItemID.DarkSideHallow, 66));
			};
			if(npc.type == NPCID.WallofFlesh) {
				npcLoot.Add(ItemDropRule.Common(ItemID.FlowingMagma, 10));
			};
			if(npc.type == NPCID.Werewolf) {
				npcLoot.Add(ItemDropRule.Common(ItemID.TheWerewolf, 150));
			};
			if(npc.type == NPCID.WindyBalloon) {
				npcLoot.Add(ItemDropRule.Common(ItemID.LoveisintheTrashSlot, 16));
	        };
			if(npc.type == NPCID.Wolf) {	
				npcLoot.Add(ItemDropRule.Food(ItemID.Steak, 40)); 
				npcLoot.Add(ItemDropRule.Common(ItemID.SparkyPainting, 66));
			};
			if(npc.type == NPCID.WyvernHead) {
				npcLoot.Add(ItemDropRule.OneFromOptions(40, ItemID.SkyGuardian, ItemID.HighPitch)); 
				npcLoot.Add(ItemDropRule.Common(ItemID.SunOrnament, 75));
			};
			if(npc.type == NPCID.Zombie || npc.type == NPCID.BigFemaleZombie || npc.type == NPCID.SmallFemaleZombie || npc.type == NPCID.BigTwiggyZombie || npc.type == NPCID.SmallTwiggyZombie || npc.type == NPCID.BigSwampZombie || npc.type == NPCID.SmallSwampZombie || npc.type == NPCID.BigSlimedZombie || npc.type == NPCID.SmallSlimedZombie || npc.type == NPCID.BigPincushionZombie || npc.type == NPCID.SmallPincushionZombie || npc.type == NPCID.BigBaldZombie || npc.type == NPCID.SmallBaldZombie || npc.type == NPCID.BigZombie || npc.type == NPCID.SmallZombie || npc.type == NPCID.BaldZombie || npc.type == NPCID.PincushionZombie || npc.type == NPCID.SlimedZombie || npc.type == NPCID.SwampZombie || npc.type == NPCID.TwiggyZombie || npc.type == NPCID.FemaleZombie || npc.type == NPCID.ZombieDoctor || npc.type == NPCID.ZombieSuperman || npc.type == NPCID.ZombiePixie || npc.type == NPCID.ZombieXmas || npc.type == NPCID.ZombieSweater || npc.type == NPCID.ArmedZombie || npc.type == NPCID.ArmedZombiePincussion || npc.type == NPCID.ArmedZombieSlimed || npc.type == NPCID.ArmedZombieSwamp || npc.type == NPCID.ArmedZombieTwiggy || npc.type == NPCID.ArmedZombieCenx || npc.type == NPCID.TorchZombie || npc.type == NPCID.ArmedTorchZombie) {		
			    npcLoot.Add(ItemDropRule.Common(ItemID.GloriousNight, 150));
			};
			if(npc.type == NPCID.ZombieEskimo || npc.type == NPCID.ArmedZombieEskimo) {	
				npcLoot.Add(ItemDropRule.Food(ItemID.HandWarmer, 25)); 
				npcLoot.Add(ItemDropRule.Common(ItemID.AuroraBorealis, 100));
			};
			if(npc.type == NPCID.ZombieMerman || npc.type == NPCID.EyeballFlyingFish || npc.type == NPCID.GoblinShark || npc.type == NPCID.BloodEelHead) {		
			    npcLoot.Add(ItemDropRule.OneFromOptions(20, ItemID.BloodMoonRising, ItemID.BloodyGoblet));
			};
        }
	}
}