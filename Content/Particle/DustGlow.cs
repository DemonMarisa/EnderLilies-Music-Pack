using EnderLiliesMusicPack.Core.ParticleSystem;
using EnderLiliesMusicPack.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnderLiliesMusicPack.Content.Particle
{
    public class DustGlow : BaseParticle
    {
        public float VelocityRot = 0;
        public override BlendState BlendState => BlendState.Additive;
        public DustGlow(Vector2 position, Vector2 velocity, Color color, int lifetime, float Rot)
        {
            Position = position;
            Velocity = velocity;
            DrawColor = color;
            Lifetime = lifetime;
            Rotation = Rot;
        }
        public override void OnSpawn()
        {
            Scale = 0.035f;
            Opacity = 0;
            VelocityRot = Main.rand.NextFloat(-0.03f, 0.03f);
        }
        public override void Update()
        {
            float Progress = (float)Math.Sin((float)Time * VelocityRot / 36f);
            Opacity = MathHelper.Lerp(Opacity, 0.8f, 0.12f);
            Scale = MathHelper.Lerp(0.035f, 0f, EasingHelper.EaseInCubic(LifetimeRatio));

            Velocity = Velocity.RotatedBy(VelocityRot);
            Velocity *= MathHelper.Lerp(1f, 0f, EasingHelper.EaseInCubic(LifetimeRatio));

            Rotation = Rotation + VelocityRot;
        }
    }
}
