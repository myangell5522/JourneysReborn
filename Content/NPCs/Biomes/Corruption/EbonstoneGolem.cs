using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Armor.Vanity;
using JourneysReborn.Content.Items.Misc.Blocks.Banners;
using JourneysReborn.Content.Projectiles.Hostile;

namespace JourneysReborn.Content.NPCs.Biomes.Corruption
{
    public class EbonstoneGolem : BiomeGolem
    {
        public override int BlockItem => ItemID.EbonstoneBlock;
        public override int HeadItem => ModContent.ItemType<EbonstoneGolemHead>();
        public override int BannerItemType => ModContent.ItemType<EbonstoneGolemBanner>();
        public override int RockProjectile => ModContent.ProjectileType<EbonstoneRock>();
        public override int BoulderProjectile => ModContent.ProjectileType<EbonstoneBoulderProjectile>();
        public override int SpawnTile => TileID.Ebonstone;
        public override int RockDamage => 50;
        public override int BoulderDamage => 140;
        public override IBestiaryInfoElement[] BestiaryElements => new IBestiaryInfoElement[]
        {
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheCorruption,
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,
            new FlavorTextBestiaryInfoElement("A hulking ebonstone construct that hurls cursed rock through the caverns.")
        };

        protected override bool InCorrectBiome(NPCSpawnInfo spawnInfo) => spawnInfo.Player.ZoneCorrupt;
    }
}
