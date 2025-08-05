using EnderLiliesMusicPack.Content.Particle;
using EnderLiliesMusicPack.Core.MusicSystem;
using EnderLiliesMusicPack.LiliesPlayer;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.Items
{
    public class CheckModCompItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ItemsThatAllowRepeatedRightClick[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.damage = 55;
            Item.DamageType = DamageClass.Melee;
            Item.useAnimation = 30;
            Item.useTime = 30;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 5f;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.height = 42;
            Item.rare = ItemRarityID.Orange;
            Item.shootSpeed = 10;
        }
        public override bool AltFunctionUse(Player player) => true;
        public override bool? UseItem(Player player)
        {
            new Kirakira(Main.MouseWorld, -Vector2.UnitY, Color.White, 240, MathHelper.PiOver4).Spawn();
            return base.CanUseItem(player);
        }
    }
}
