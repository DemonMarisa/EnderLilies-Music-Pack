using EnderLiliesMusicPack.Core.ParticleSystem;
using EnderLiliesMusicPack.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace EnderLiliesMusicPack.Content.Particle
{
    public class CircleDisolve : BaseParticle
    {
        public override BlendState BlendState => BlendState.Additive;
        public CircleDisolve(Vector2 position, Vector2 velocity, Color color, int lifetime, float Rot, float opacity)
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
            float Progress = (float)Math.Sin(LifetimeRatio * MathHelper.Pi * 2);
            Opacity = 0.5f * Progress;
            Scale = Progress * 0.5f;
        }
    }
}