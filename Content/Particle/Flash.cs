using EnderLiliesMusicPack.Core.ParticleSystem;
using EnderLiliesMusicPack.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EnderLiliesMusicPack.Content.Particle
{
    public class Flash : BaseParticle
    {
        public override BlendState BlendState => BlendState.Additive;
        public Flash(Vector2 position, Vector2 velocity, Color color, int lifetime, float scale)
        {
            Position = position;
            Velocity = velocity;
            DrawColor = color;
            Lifetime = lifetime;
            Scale = scale;
        }
        public override void OnSpawn()
        {
            Opacity = 0;
        }
        public override void Update()
        {
            Scale = MathHelper.Lerp(0.2f, 0.3f, LifetimeRatio);

            if (LifetimeRatio < 0.5f)
                Opacity = MathHelper.Lerp(Opacity, 1f, 0.03f);
            else
                Opacity = MathHelper.Lerp(Opacity, 0f, 0.04f);

        }
    }
}
