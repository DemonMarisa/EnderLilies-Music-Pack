using EnderLiliesMusicPack.Assets.Textures;
using EnderLiliesMusicPack.Assets.Textures.TextureRegistry;
using EnderLiliesMusicPack.Config;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.UI.Gamepad;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnderLiliesMusicPack.Core.ILEditingStuff.UIChange
{
    public class CursorChange
    {
        // 记录了原版的光标绘制ID对应的名称
        public enum  CursorType
        {
            Collect = 3,
            Discard = 6,
            Selling = 10,
        }
        public static float CursorLight = 0f;
        #region 禁用原版光标描边
        public static Vector2 DrawThickCursor(On_Main.orig_DrawThickCursor orig, bool smart)
        {
            if (LiliesMusicPackConfig.Instance.CursorChange == 0)
            {
                orig(smart);
                return Vector2.Zero;
            }
            return Vector2.Zero;
        }
        #endregion
        #region 覆盖绘制光标
        public static void UseNewCursorEffect(On_Main.orig_DrawCursor orig, Vector2 bonus, bool smart)
        {
            // 如果配置为0则使用原游标
            if (LiliesMusicPackConfig.Instance.CursorChange == 0 || Main.LocalPlayer.gravDir ==  -1)
            {
                 orig(bonus, smart);
                 return;
            }

            Player player = Main.LocalPlayer;
            if (player.dead)
            {
                Main.ClearSmartInteract();
                Main.TileInteractionLX = (Main.TileInteractionHX = (Main.TileInteractionLY = (Main.TileInteractionHY = -1)));
            }

            CursorLight = ((float)Math.Sin(Main.GlobalTimeWrappedHourly) + 1) * 0.5f;

            float scale = 0.15f;

            if (LiliesMusicPackConfig.Instance.CursorChange == 1)
            {
                DrawCustomCursor(UITextureRegistry.LiliesCursor.Value);
                return;
            }
            else if (LiliesMusicPackConfig.Instance.CursorChange == 2)
            {
                scale = scale * 3.7f;
                DrawCustomCursor(UITextureRegistry.LilacCursor.Value);
                return;
            }

            void DrawCustomCursor(Texture2D CursorTex)
            {
                Vector2 offset = new(-9.5f, -5);
                Color DrawColor = Color.White;
                Vector2 DrawPos = Main.MouseScreen + bonus + offset;

                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);

                Main.spriteBatch.Draw(CursorTex, DrawPos, null, DrawColor, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.Additive, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);

                Main.spriteBatch.Draw(CursorTex, DrawPos, null, DrawColor * CursorLight, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.GameViewMatrix.EffectMatrix);
            }
        }
        #endregion
        #region 覆盖绘制光标的特效
        public static void UseNewCursor(On_Main.orig_DrawInterface_36_Cursor orig)
        {
            if (LiliesMusicPackConfig.Instance.CursorChange == 0 || Main.LocalPlayer.gravDir == -1)
            {
                orig();
                return;
            }
            Player player = Main.LocalPlayer;
            if (player.dead)
            {
                Main.ClearSmartInteract();
                Main.TileInteractionLX = (Main.TileInteractionHX = (Main.TileInteractionLY = (Main.TileInteractionHY = -1)));
            }

            CursorLight = ((float)Math.Sin(Main.GlobalTimeWrappedHourly) + 1) * 0.5f;

            float scale = 0.15f;

            if (LiliesMusicPackConfig.Instance.CursorChange == 1)
            {
                Texture2D texture = UITextureRegistry.LiliesCursor.Value;
                Vector2 offset = new(-9.5f, -5);
                switch (Main.cursorOverride)
                {
                    case (int)CursorType.Collect:
                        scale = 0.17f;
                        texture = UITextureRegistry.LiliesCollectCursor.Value;
                        offset = new(-13, -9f);
                        break;
                    case (int)CursorType.Discard:
                        texture = UITextureRegistry.LiliesDiscardCursor.Value;
                        break;
                    case (int)CursorType.Selling:
                        texture = UITextureRegistry.LiliesSellingCursor.Value;
                        break;
                    default:
                        break;
                }
                DrawCustomCursor(texture, offset);
                return;
            }
            else if (LiliesMusicPackConfig.Instance.CursorChange == 2)
            {
                scale = 0.55f;
                Texture2D texture = UITextureRegistry.LilacCursor.Value;
                Vector2 offset = new(-9.5f, -5);
                switch (Main.cursorOverride)
                {
                    case (int)CursorType.Collect:
                        scale = 0.65f;
                        texture = UITextureRegistry.LilacCollectCursor.Value;
                        offset = new(-6f, -2);
                        break;
                    case (int)CursorType.Discard:
                        scale = 0.25f;
                        texture = UITextureRegistry.LilacDiscardCursor.Value;
                        offset = new(-20, -15);
                        break;
                    case (int)CursorType.Selling:
                        scale = 0.25f;
                        texture = UITextureRegistry.LilacSellingCursor.Value;
                        offset = new(-20, -15);
                        break;
                    default:
                        break;
                }
                DrawCustomCursor(texture, offset);
                return;
            }
            return;
            void DrawCustomCursor(Texture2D CursorTex, Vector2 offset2)
            {
                Vector2 offset = offset2;
                Color DrawColor = Color.White;
                Vector2 DrawPos = Main.MouseScreen + offset;
                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);

                Main.spriteBatch.Draw(CursorTex, DrawPos, null, DrawColor, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.Additive, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);

                Main.spriteBatch.Draw(CursorTex, DrawPos, null, DrawColor * CursorLight, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);

                Main.spriteBatch.End();
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.GameViewMatrix.EffectMatrix);
            }
        }
        #endregion
    }
}
