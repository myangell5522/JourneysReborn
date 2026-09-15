using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using JourneysReborn.Content.NPCs.Biomes.Corruption;
using JourneysReborn.Content.NPCs.Biomes.Crimson;
using JourneysReborn.Content.NPCs.Biomes.Hallow;
using JourneysReborn.Content.NPCs.Events.GoblinArmy;

namespace JourneysReborn.Content.Items.Misc.Blocks.Banners
{
    public abstract class EnemyBannerItem : ModItem
    {
        public abstract int BannerTile { get; }

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(BannerTile);
            Item.width = 12;
            Item.height = 28;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 10);
        }
    }

    public abstract class EnemyBannerTile : ModTile
    {
        public abstract int BannerNpc { get; }

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 20 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom | AnchorType.PlanterBox, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);

            DustType = -1;
            AddMapEntry(new Color(13, 88, 130), Language.GetText("MapObject.Banner"));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (!closer)
                return;

            Main.SceneMetrics.NPCBannerBuff[BannerNpc] = true;
            Main.SceneMetrics.hasBanner = true;
        }
    }

    public class EbonstoneGolemBanner : EnemyBannerItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/EbonstoneGolemBanner_Item";
        public override int BannerTile => ModContent.TileType<EbonstoneGolemBannerTile>();
    }

    public class EbonstoneGolemBannerTile : EnemyBannerTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/EbonstoneGolemBanner_Tile";
        public override int BannerNpc => ModContent.NPCType<EbonstoneGolem>();
    }

    public class CrimstoneGolemBanner : EnemyBannerItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/CrimstoneGolemBanner_Item";
        public override int BannerTile => ModContent.TileType<CrimstoneGolemBannerTile>();
    }

    public class CrimstoneGolemBannerTile : EnemyBannerTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/CrimstoneGolemBanner_Tile";
        public override int BannerNpc => ModContent.NPCType<CrimstoneGolem>();
    }

    public class PearlstoneGolemBanner : EnemyBannerItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/PearlstoneGolemBanner_Item";
        public override int BannerTile => ModContent.TileType<PearlstoneGolemBannerTile>();
    }

    public class PearlstoneGolemBannerTile : EnemyBannerTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/PearlstoneGolemBanner_Tile";
        public override int BannerNpc => ModContent.NPCType<PearlstoneGolem>();
    }

    public class GoblinMechanicBanner : EnemyBannerItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/GoblinMechanicBanner_Item";
        public override int BannerTile => ModContent.TileType<GoblinMechanicBannerTile>();
    }

    public class GoblinMechanicBannerTile : EnemyBannerTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/GoblinMechanicBanner_Tile";
        public override int BannerNpc => ModContent.NPCType<GoblinMechanic>();
    }

    public class GoblinShamanBanner : EnemyBannerItem
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/GoblinShamanBanner_Item";
        public override int BannerTile => ModContent.TileType<GoblinShamanBannerTile>();
    }

    public class GoblinShamanBannerTile : EnemyBannerTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/Banners/GoblinShamanBanner_Tile";
        public override int BannerNpc => ModContent.NPCType<GoblinShaman>();
    }
}
