using EnderLiliesMusicPack.Assets.Textures.TextureRegistry;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Assets.Textures
{
    public class LilyTextureRegistry : ModSystem
    {
        #region 路径
        public static string NorPath => "EnderLiliesMusicPack/Assets/Textures";

        public static string ExPath => "EnderLiliesMusicPack/Assets/Textures/ExtraTextures";

        public static string UIPath => "EnderLiliesMusicPack/Assets/Textures/UI";

        public static string MiscPath => "EnderLiliesMusicPack/Assets/Textures/Misc";
        #endregion

        #region 材质
        public static Asset<Texture2D> LilyLight { get; private set; }

        public static Asset<Texture2D> Flash { get; private set; }

        public static Asset<Texture2D> Kirakira { get; private set; }

        public static Asset<Texture2D> DustGlow { get; private set; }

        public static Asset<Texture2D> CircleDisolve { get; private set; }

        public static Asset<Texture2D> Invisible { get; private set; }
        #endregion

        #region 加载卸载
        public override void Load()
        {
            LilyLight = ModContent.Request<Texture2D>($"{ExPath}/LilyLight", AssetRequestMode.ImmediateLoad);
            Flash = ModContent.Request<Texture2D>($"{ExPath}/Flash", AssetRequestMode.ImmediateLoad);
            Kirakira = ModContent.Request<Texture2D>($"{ExPath}/Kirakira_1", AssetRequestMode.ImmediateLoad);
            DustGlow = ModContent.Request<Texture2D>($"{ExPath}/DustGlow", AssetRequestMode.ImmediateLoad);
            CircleDisolve = ModContent.Request<Texture2D>($"{ExPath}/CircleDisolve", AssetRequestMode.ImmediateLoad);
            Invisible = ModContent.Request<Texture2D>($"{MiscPath}/Invisible", AssetRequestMode.ImmediateLoad);
            UITextureRegistry.Load();
        }

        public override void Unload()
        {
            LilyLight = null;
            Flash = null;
            Kirakira = null;
            DustGlow = null;
            CircleDisolve = null;
            Invisible = null;
            UITextureRegistry.Unload();
        }
        #endregion
    }
}
