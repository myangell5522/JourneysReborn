using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using JourneysReborn.Content.Items.Gear.Armor.Vanity;
using JourneysReborn.Content.Items.Misc.Blocks.Banners;
using JourneysReborn.Content.Projectiles.Hostile;

namespace JourneysReborn.Content.NPCs.Biomes.Crimson
{
    public class CrimstoneGolem : BiomeGolem
    {
        public override int BlockItem => ItemID.CrimstoneBlock;
        public override int HeadItem => ModContent.ItemType<CrimstoneGolemHead>();
        public override int BannerItemType => ModContent.ItemType<CrimstoneGolemBanner>();
        public override int RockProjectile => ModContent.ProjectileType<CrimstoneRock>();
        public override int BoulderProjectile => ModContent.ProjectileType<CrimstoneBoulderProjectile>();
        public override int SpawnTile => TileID.Crimstone;
        public override int RockDamage => 50;
        public override int BoulderDamage => 140;
        public override IBestiaryInfoElement[] BestiaryElements => new IBestiaryInfoElement[]
        {
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheCrimson,
            BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,
            new FlavorTextBestiaryInfoElement("Mods.JourneysReborn.Bestiary.CrimstoneGolem")
        };

        protected override bool InCorrectBiome(NPCSpawnInfo spawnInfo) => spawnInfo.Player.ZoneCrimson;
    }
}
