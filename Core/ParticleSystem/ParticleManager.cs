using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Core.ParticleSystem
{
    public class ParticleManager : ModSystem
    {
        // 别在外部可以修改了，至少别人都加了readonly（
        public static readonly List<BaseParticle> ActiveParticles = [];

        // 储存所有粒子类型的ID
        // public static readonly Dictionary<Type, int> particleTypes;
        #region 加载卸载
        public override void Load()
        {
            On_Main.DrawDust += DrawParticles;
        }
        public override void Unload()
        {
            On_Main.DrawDust -= DrawParticles;
        }
        #endregion

        // 粒子更新
        public override void PostUpdateDusts()
        {
            // 从原Lum的代码中移植的方法，原注释如下
            // Testing has shown that fast parallel is faster in most cases with lower particle counts, and drastically faster with higher.
            if (Main.dedServ)
                return;

            if (ActiveParticles.Count == 0)
                return;

            for (int i = 0; i < ActiveParticles.Count; i++)
            {
                ActiveParticles[i].Update();
                ActiveParticles[i].Position += ActiveParticles[i].Velocity;
                ActiveParticles[i].Time++;
            }

            // 移除生命周期已结束的粒子
            ActiveParticles.RemoveAll(particle =>
            {
                if (particle.Time >= particle.Lifetime)
                {
                    particle.Kill();
                    return true;
                }
                return false;
            });
        }

        // 绘制粒子
        public static void DrawParticles(On_Main.orig_DrawDust orig, Main self)
        {
            // 调用源
            orig(self);

            #region 渲染粒子
            for (int i = 0; i < ActiveParticles.Count; i++)
            {
                Main.spriteBatch.Begin(SpriteSortMode.Deferred, ActiveParticles[i].BlendState, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.GameViewMatrix.TransformationMatrix);

                ActiveParticles[i].Draw(Main.spriteBatch);

                Main.spriteBatch.End();
            }
            #endregion
        }
    }
}
