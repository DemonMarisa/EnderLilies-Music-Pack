using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using EnderLiliesMusicPack.MusicSystem;

namespace EnderLiliesMusicPack.Items
{
    public class DebugItem : ModItem
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
            if (player.altFunctionUse == 2)
            {
                LiliesMusicEventSystem.PlayedEvents.Add("LiliesFirstEnterWorld");
                LiliesMusicEventSystem.PlayedEvents.Add("LiliesHardmodeStarted");
                LiliesMusicEventSystem.PlayedEvents.Add("LiliesDownedMoonLord");
                LiliesMusicEventSystem.PlayedEvents.Add("LiliesDownedMoonLord2");
                Main.NewText("添加所有音乐事件标记");
            }
            else
            {
                LiliesMusicEventSystem.PlayedEvents.Remove("LiliesFirstEnterWorld");
                LiliesMusicEventSystem.PlayedEvents.Remove("LiliesHardmodeStarted");
                LiliesMusicEventSystem.PlayedEvents.Remove("LiliesDownedMoonLord");
                LiliesMusicEventSystem.PlayedEvents.Remove("LiliesDownedMoonLord2");
                Main.NewText("清除所有音乐事件标记");
            }
            return base.CanUseItem(player);
        }
    }
}
