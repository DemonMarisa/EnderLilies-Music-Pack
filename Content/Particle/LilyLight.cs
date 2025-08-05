using EnderLiliesMusicPack.Core.ParticleSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnderLiliesMusicPack.Content.Particle
{
    public class LilyLight : BaseParticle
    {
        public override BlendState BlendState => BlendState.NonPremultiplied;
        public LilyLight(Vector2 position, Vector2 velocity, Color color, int lifetime, float Rot, float opacity)
        {
            Position = position;
            Velocity = velocity;
            DrawColor = color;
            Lifetime = lifetime;
            Rotation = Rot;
            Opacity = opacity;
        }

        public override void Update()
        {
            Scale = 0.35f;
            float Progress = (float)Math.Sin(LifetimeRatio * MathHelper.Pi * 2);
            Opacity = 1f * Progress;
        }
    }
}
