using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using Terraria.DataStructures;
using System.Linq;
using Terraria.Graphics;
using Terraria.GameContent.Generation;
using JourneysReborn.Content.Items.Misc.Ores;

namespace JourneysReborn.WorldGen
{
    public class BasicWorldGen : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if(ShiniesIndex != 1) tasks.Insert(ShiniesIndex + 1, new LithiumOreGen("Spawning Lithium Ore", 100f));
        }
    }

    public class LithiumOreGen : GenPass
    {
        public LithiumOreGen(string name, float loadWeight) : base(name, loadWeight) {
		}

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "[Lunaria Mod] Adding Lithium into the world";

            for(int x = 0; x < Main.maxTilesX; x++) {
                for(int y = (int)Main.worldSurface; y < Main.maxTilesY; y++) {
                    Tile tile = Framing.GetTileSafely(x, y);
                    if(tile.TileType == TileID.Stone) {
                        if(Main.rand.NextBool(1, y > Main.rockLayer ? 1250 : 1500)) {
                            Terraria.WorldGen.OreRunner(x, y, y > Main.rockLayer ? 3.25 : 2.00, 3, (ushort)ModContent.TileType<LithiumOre_Tile>());
                        };
                    } else if(tile.TileType == TileID.IceBlock) {
                        if(Main.rand.NextBool(1, y > Main.rockLayer ? 1000 : 1250)) {
                            Terraria.WorldGen.OreRunner(x, y, y > Main.rockLayer ? 4.75 : 3.75, 3, (ushort)ModContent.TileType<LithiumOre_Tile>());
                        };
                    } else if(tile.TileType == TileID.Sandstone) {
                        if(Main.rand.NextBool(1, y > Main.rockLayer ? 1850 : 2250)) {
                            Terraria.WorldGen.OreRunner(x, y, y > Main.rockLayer ? 4.00 : 3.50, 3, (ushort)ModContent.TileType<LithiumOre_Tile>());
                        };
                    } else if(tile.TileType == TileID.Mud) {
                        if(Main.rand.NextBool(1, y > Main.rockLayer ? 2750 : 3250)) {
                            Terraria.WorldGen.OreRunner(x, y, y > Main.rockLayer ? 2.25 : 2.00, 3, (ushort)ModContent.TileType<LithiumOre_Tile>());
                        };
                    };
                };
            };
        }
    }
}