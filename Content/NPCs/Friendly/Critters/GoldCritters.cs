using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.NPCs.Friendly.Critters
{
    public abstract class GoldCritter : ModNPC
    {
        public abstract int VanillaType { get; }
        public abstract int CatchItem { get; }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[VanillaType];
            Main.npcCatchable[Type] = true;
            NPCID.Sets.CountsAsCritter[Type] = true;
            NPCID.Sets.TakesDamageFromHostilesWithoutBeingFriendly[Type] = true;
            NPCID.Sets.TownCritter[Type] = true;
            NPCID.Sets.NormalGoldCritterBestiaryPriority.Add(Type);
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(VanillaType);
            NPC.catchItem = CatchItem;
            NPC.rarity = 3;
            NPC.value = 0;
            AIType = VanillaType;
            AnimationType = VanillaType;
        }

        public virtual IBestiaryInfoElement SpawnBiome => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface;

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                SpawnBiome,
                new FlavorTextBestiaryInfoElement("Mods.JourneysReborn.Bestiary.GoldCritter")
            });
        }

        public override void HitEffect(NPC.HitInfo hit)
        {
            if (NPC.life > 0)
                return;

            for (int i = 0; i < 8; i++)
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.GoldCoin, hit.HitDirection, -1f);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo) => 0f;
    }

    public abstract class GoldCritterItem : ModItem
    {
        public abstract int SpawnNPC { get; }
        public abstract int VanillaItem { get; }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(VanillaItem);
            Item.makeNPC = SpawnNPC;
            Item.value = Item.buyPrice(gold: 10);
            Item.rare = ItemRarityID.Orange;
        }
    }

    public class GoldCockatiel : GoldCritter
    {
        public override int VanillaType => NPCID.YellowCockatiel;
        public override int CatchItem => ModContent.ItemType<GoldCockatielItem>();
    }

    public class GoldCockatielItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldCockatiel>();
        public override int VanillaItem => ItemID.YellowCockatiel;
    }

    public class GoldDuck : GoldCritter
    {
        public override int VanillaType => NPCID.Duck;
        public override int CatchItem => ModContent.ItemType<GoldDuckItem>();
    }

    public class GoldDuckItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldDuck>();
        public override int VanillaItem => ItemID.Duck;
    }

    public class GoldMacaw : GoldCritter
    {
        public override int VanillaType => NPCID.ScarletMacaw;
        public override int CatchItem => ModContent.ItemType<GoldMacawItem>();
    }

    public class GoldMacawItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldMacaw>();
        public override int VanillaItem => ItemID.ScarletMacaw;
    }

    public class GoldOwl : GoldCritter
    {
        public override int VanillaType => NPCID.Owl;
        public override int CatchItem => ModContent.ItemType<GoldOwlItem>();
    }

    public class GoldOwlItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldOwl>();
        public override int VanillaItem => ItemID.Owl;
    }

    public class GoldPenguin : GoldCritter
    {
        public override string Texture => "JourneysReborn/Content/NPCs/Friendly/Critters/GoldPenquin";
        public override int VanillaType => NPCID.Penguin;
        public override int CatchItem => ModContent.ItemType<GoldPenguinItem>();
        public override IBestiaryInfoElement SpawnBiome => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Snow;
    }

    public class GoldPenguinItem : GoldCritterItem
    {
        public override string Texture => "JourneysReborn/Content/NPCs/Friendly/Critters/GoldPenquinItem";
        public override int SpawnNPC => ModContent.NPCType<GoldPenguin>();
        public override int VanillaItem => ItemID.Penguin;
    }

    public class GoldScorpion : GoldCritter
    {
        public override int VanillaType => NPCID.Scorpion;
        public override int CatchItem => ModContent.ItemType<GoldScorpionItem>();
        public override IBestiaryInfoElement SpawnBiome => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Desert;
    }

    public class GoldScorpionItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldScorpion>();
        public override int VanillaItem => ItemID.Scorpion;

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.bait = 50;
        }
    }

    public class GoldSeagull : GoldCritter
    {
        public override int VanillaType => NPCID.Seagull;
        public override int CatchItem => ModContent.ItemType<GoldSeagullItem>();
        public override IBestiaryInfoElement SpawnBiome => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Ocean;
    }

    public class GoldSeagullItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldSeagull>();
        public override int VanillaItem => ItemID.Seagull;
    }

    public class GoldToucan : GoldCritter
    {
        public override string Texture => "JourneysReborn/Content/NPCs/Friendly/Critters/GoldTucan";
        public override int VanillaType => NPCID.Toucan;
        public override int CatchItem => ModContent.ItemType<GoldToucanItem>();
    }

    public class GoldToucanItem : GoldCritterItem
    {
        public override string Texture => "JourneysReborn/Content/NPCs/Friendly/Critters/GoldTucanItem";
        public override int SpawnNPC => ModContent.NPCType<GoldToucan>();
        public override int VanillaItem => ItemID.Toucan;
    }

    public class GoldTurtle : GoldCritter
    {
        public override int VanillaType => NPCID.Turtle;
        public override int CatchItem => ModContent.ItemType<GoldTurtleItem>();
        public override IBestiaryInfoElement SpawnBiome => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle;
    }

    public class GoldTurtleItem : GoldCritterItem
    {
        public override int SpawnNPC => ModContent.NPCType<GoldTurtle>();
        public override int VanillaItem => ItemID.Turtle;
    }
}
