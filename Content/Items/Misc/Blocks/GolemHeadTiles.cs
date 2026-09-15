using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace JourneysReborn.Content.Items.Misc.Blocks
{
    public abstract class GolemHeadTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 22, 22 };
            TileObjectData.newTile.CoordinateWidth = 22;
            TileObjectData.newTile.CoordinatePadding = 0;
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.addTile(Type);

            AddMapEntry(MapColor, Language.GetText("MapObject.Head"));
            DustType = HeadDust;
        }

        protected abstract Color MapColor { get; }
        protected abstract int HeadDust { get; }
    }

    public class EbonstoneGolemHeadTile : GolemHeadTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/EbonstoneGolemHead_Tile";
        protected override Color MapColor => new Color(80, 50, 120);
        protected override int HeadDust => DustID.Corruption;
    }

    public class CrimstoneGolemHeadTile : GolemHeadTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/CrimstoneGolemHead_Tile";
        protected override Color MapColor => new Color(140, 40, 40);
        protected override int HeadDust => DustID.CrimtaneWeapons;
    }

    public class PearlstoneGolemHeadTile : GolemHeadTile
    {
        public override string Texture => "JourneysReborn/Content/Items/Misc/Blocks/PearlstoneGolemHead_Tile";
        protected override Color MapColor => new Color(180, 140, 180);
        protected override int HeadDust => DustID.Pearlwood;
    }
}
