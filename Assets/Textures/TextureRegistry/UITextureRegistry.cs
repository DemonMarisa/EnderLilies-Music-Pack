using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Assets.Textures.TextureRegistry
{
    public class UITextureRegistry
    {
        // 常规状态下的指针
        public static Asset<Texture2D> LiliesCursor { get; private set; }
        public static Asset<Texture2D> LilacCursor { get; private set; }

        // 收藏物品时的指针
        public static Asset<Texture2D> LiliesCollectCursor { get; private set; }
        public static Asset<Texture2D> LilacCollectCursor { get; private set; }

        // 按住Ctrl，准备出售物品时的指针
        public static Asset<Texture2D> LiliesSellingCursor { get; private set; }
        public static Asset<Texture2D> LilacSellingCursor { get; private set; }

        // 按住Ctrl，准备丢掉物品时的指针
        public static Asset<Texture2D> LiliesDiscardCursor { get; private set; }
        public static Asset<Texture2D> LilacDiscardCursor { get; private set; }

        public static void Load()
        {
            LiliesCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LiliesCursor", AssetRequestMode.ImmediateLoad);
            LilacCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LilacCursor", AssetRequestMode.ImmediateLoad);

            LiliesCollectCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LiliesCursor_Collect", AssetRequestMode.ImmediateLoad);
            LilacCollectCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LilacCursor_Collect", AssetRequestMode.ImmediateLoad);

            LiliesSellingCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LiliesCursor_Selling", AssetRequestMode.ImmediateLoad);
            LilacSellingCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LilacCursor_Selling", AssetRequestMode.ImmediateLoad);

            LiliesDiscardCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LiliesCursor_Discard", AssetRequestMode.ImmediateLoad);
            LilacDiscardCursor = ModContent.Request<Texture2D>($"{LilyTextureRegistry.UIPath}/LilacCursor_Discard", AssetRequestMode.ImmediateLoad);
        }

        public static void Unload()
        {
            LiliesCursor = null;
            LilacCursor = null;

            LiliesCollectCursor = null;
            LilacCollectCursor = null;

            LiliesSellingCursor = null;
            LilacSellingCursor = null;

            LiliesDiscardCursor = null;
            LilacDiscardCursor = null;
        }
    }
}
