using EnderLiliesMusicPack.Assets.Textures;
using EnderLiliesMusicPack.Content.Particle;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Utilities;
using Humanizer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnderLiliesMusicPack.Content.Tiles
{
    public abstract class BaseMusicBoxTile : ModTile, ILocalizedModType
    {
        public abstract int belongwhom { get; }
        public int liliesID = 0;
        public int lilacID = 1;
        public int AniCD = 0;
        public float alphaMult = 0;
        public new string LocalizationCategory => "MusicBoxTiles";
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileID.Sets.HasOutlines[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleLineSkip = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(191, 142, 111), LiliesUtils.GetText("MusicBoxTiles"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = TileLoader.GetItemDropFromTypeAndStyle(Type);
        }

        public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings)
        {
            return true;
        }
        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
        {
            if (Lighting.UpdateEveryFrame && new FastRandom(Main.TileFrameSeed).WithModifier(i, j).Next(4) != 0)
            {
                return;
            }

            Tile tile = Main.tile[i, j];

            if (MusicBoxOFF(tile))
            {
                return;
            }
            if (Main.gamePaused)
                return;

            if (belongwhom == LiliesRarityID.liliesID)
                LiliesDust(i, j);
            else if (belongwhom == LiliesRarityID.lilacID)
                LilcaDust(i, j);
            else
                LiliesDust(i, j);
        }
        public void LiliesDust(int i, int j)
        {
            AniCD++;
            Vector2 position = new Vector2(i * 16, j * 16) + new Vector2(16, 18);
            if (AniCD > 20)
            {
                new Flash(position, Vector2.Zero, Color.White, 240, 0).Spawn();
                new CircleDisolve(position, Vector2.Zero, Color.White, 480, 0, 0).Spawn();
                AniCD = 0;
            }
            if (Main.rand.NextBool(3))
            {
                // Main.NewText("Spawn");
                new Kirakira(position + new Vector2(Main.rand.Next(-16, 16), 0), -Vector2.UnitY * Main.rand.NextFloat(0.3f, 1.1f), Color.White, Main.rand.Next(60, 90), MathHelper.PiOver4).Spawn();
            }
        }

        public void LilcaDust(int i, int j)
        {
            AniCD++;
            Vector2 position = new Vector2(i * 16, j * 16) + new Vector2(16, 18);
            if (AniCD > 15)
            {
                new LilyLight(position, Vector2.Zero, new(0, 191, 255), 360, 0, 0).Spawn();
                AniCD = 0;
            }
            if (Main.rand.NextBool(3))
            {
                // Main.NewText("Spawn");
                new DustGlow(position + new Vector2(Main.rand.Next(-16, 16), 0), -Vector2.UnitY * Main.rand.NextFloat(0.3f, 1.1f), Color.SkyBlue, Main.rand.Next(45, 70), MathHelper.PiOver4).Spawn();
            }
        }
        public override void EmitParticles(int i, int j, Tile tile, short tileFrameX, short tileFrameY, Color tileLight, bool visible)
        {
            if (!visible)
                return;
        }

        public static bool MusicBoxOFF(Tile tile)
        {
            return !TileDrawing.IsVisible(tile) || tile.TileFrameX != 36 || tile.TileFrameY % 36 != 0;
        }
    }
}
