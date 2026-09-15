using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Armor.Vanity;
using JourneysReborn.Content.Items.Misc.Blocks.Banners;
using JourneysReborn.Content.Projectiles.Hostile;

namespace JourneysReborn.Content.NPCs.Biomes.Hallow
{
    public class PearlstoneGolem : BiomeGolem
    {
        public override int BlockItem => ItemID.PearlstoneBlock;
        public override int HeadItem => ModContent.ItemType<PearlstoneGolemHead>();
        public override int BannerItemType => ModContent.ItemType<PearlstoneGolemBanner>();
        public override int RockProjectile => ModContent.ProjectileType<PearlstoneRock>();
        public override int BoulderProjectile => ModContent.ProjectileType<PearlstoneBoulderProjectile>();
        public override int SpawnTile => TileID.Pearlstone;
        public override int RockDamage => 45;
        public override int BoulderDamage => 140;

        public override void SetDefaults()
        {
            base.SetDefaults();
            NPC.lifeMax = 1050;
            NPC.damage = 90;
            NPC.defense = 38;
            NPC.knockBackResist = 0.07f;
        }

        public override IBestiaryInfoElement[] BestiaryElements => new IBestiaryInfoElement[]
        {
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheHallow,
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,
            new FlavorTextBestiaryInfoElement("A pearlescent golem whose strikes leave foes disoriented.")
        };

        protected override bool InCorrectBiome(NPCSpawnInfo spawnInfo) => spawnInfo.Player.ZoneHallow;
    }
}
