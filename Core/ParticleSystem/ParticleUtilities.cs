using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnderLiliesMusicPack.Core.ParticleSystem
{
    public static class ParticleUtilities
    {
        /// <summary>
        /// 移除所有的粒子
        /// </summary>
        public static void RemoveAll()
        {
            foreach (BaseParticle particle in ParticleManager.ActiveParticles)
            {
                particle.Kill();
            }
        }
    }
}
