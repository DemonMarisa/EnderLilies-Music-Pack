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
        #endregion

        #region 材质
        public static Asset<Texture2D> LilyLight { get; private set; }
        #endregion

        #region 加载卸载
        public override void Load()
        {
            LilyLight = ModContent.Request<Texture2D>($"{NorPath}/LilyLight", AssetRequestMode.ImmediateLoad);
        }

        public override void Unload()
        {
            LilyLight = null;
        }
        #endregion
    }
}
