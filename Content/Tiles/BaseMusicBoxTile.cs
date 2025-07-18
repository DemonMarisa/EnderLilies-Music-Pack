using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria;
using Microsoft.Xna.Framework;
using EnderLiliesMusicPack.Utilities;
using EnderLiliesMusicPack.Assets.Textures;
using Humanizer;
using EnderLiliesMusicPack.Content.Rarity;

namespace EnderLiliesMusicPack.Content.Tiles
{
    public abstract class BaseMusicBoxTile : ModTile, ILocalizedModType
    {
        public abstract int belongwhom { get; }
        public int liliesID = 0;
        public int lilacID = 1;
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

            DrawLight(i, j, spriteBatch);
        }
        public static bool MusicBoxOFF(Tile tile)
        {
            return !TileDrawing.IsVisible(tile) || tile.TileFrameX != 36 || tile.TileFrameY % 36 != 0;
        }
        public void DrawLight(int i, int j, SpriteBatch spriteBatch)
        {
            #region 绘制辉光

            // 范围100-200的透明度变化
            float alphaFactor = (float)(Math.Sin(Main.GlobalTimeWrappedHourly * MathHelper.TwoPi / 5f) + 1) / 2; // 转换为0-1范围，而不是-1到1范围
            int alpha = 155 + (int)(100 * alphaFactor); // 映射到125-200范围

            Color blinkColor;

            if (belongwhom == LiliesRarityID.liliesID)
                blinkColor = new Color(255, 255, 255, alpha);
            else if (belongwhom == LiliesRarityID.lilacID)
                blinkColor = new Color(0, 191, 255, alpha);
            else
                blinkColor = new Color(255, 255, 255, alpha);

            // 保存原始混合状态
            // 重置绘制批次来设置叠加混合模式
            var originalBlendState = Main.spriteBatch.GraphicsDevice.BlendState;
            spriteBatch.End();
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive);

            // 世界坐标转化为屏幕坐标
            Vector2 position = new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y);
            // 我不知道为什么需要偏移6.5个身位才能是物块中央
            spriteBatch.Draw(LilyTextureRegistry.LilyLight.Value, position + new Vector2(208, 212), null, blinkColor, 0f, LilyTextureRegistry.LilyLight.Size() / 2, 0.55f, SpriteEffects.None, 0f);

            // 绘制后恢复原始状态
            spriteBatch.End();
            spriteBatch.Begin();

            #endregion
        }
    }
}
