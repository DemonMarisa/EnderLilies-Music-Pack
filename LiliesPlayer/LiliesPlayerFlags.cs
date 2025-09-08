using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using EnderLiliesMusicPack.Utilities;
using System;
using System.Reflection;

namespace EnderLiliesMusicPack.LiliesPlayer
{
    public partial class LiliesPlayerFlags : ModPlayer
    {
        public static bool onSurface;
        public static bool inSpace;

        public static bool inTown;
        public static bool inTownWithRain;
        public static bool inUgTown;

        public static bool isRaining;
        public static bool notRaining;
        public static bool largeWorld;
        public static bool mediumWorld;
        public static bool smallWorld;

        // mod适配
        public static bool infernumMode;
        public static bool ZoneBrimstoneCrags;
        public static bool ZoneAstralInfection;
        public static bool ZoneAbyss;
        public static bool ZoneSunkenSea;
        public static bool BossRushActive;
        // 与灾厄音乐事件的适配
        // 他俩等于false的时候就是别的mod正在播放BGM
        public static bool CalamityMusicEventInactive = true;
        // 与VCMM音乐事件的适配
        public static bool VCalamityMusicEventInactive = true;
        // 炼狱亵渎神庙
        public static bool ZoneProfanedTemple;

        public static float MusicTileRange = 525f * 16f;

        public override void PreUpdate()
        {
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
            var infernumMod = ModLoader.TryGetMod("InfernumMode", out Mod infernum);
            var remnantsMod = ModLoader.TryGetMod("Remnants", out Mod remnants);
            var noTownMusic = ModLoader.TryGetMod("NoTownMusic", out Mod notownmusic);

            float spacef = remnantsMod ? 17f : 16f;
            float spaceh = (float)Main.maxTilesX / 4200f;
            spaceh *= spaceh;

            Player player = Main.player[Main.myPlayer];

            onSurface = player.position.Y < Main.worldSurface * 16.0 + (double)Main.screenHeight / 2;
            inSpace = (float)((double)((Main.screenPosition.Y + (float)(Main.screenHeight / 2)) / spacef - (65f + 10f * spaceh)) / (Main.worldSurface / 5.0)) < 1f;
            isRaining = Main.cloudAlpha > 0f;
            notRaining = Main.cloudAlpha <= 0.01f;
            largeWorld = Main.maxTilesY == 2400;
            mediumWorld = Main.maxTilesY == 1800;
            smallWorld = Main.maxTilesY == 1200;

            if (noTownMusic)
            {
                inTown = false;
                inTownWithRain = false;
                inUgTown = false;
            }
            else
            {
                if (player.ZoneShadowCandle || player.inventory[player.selectedItem].type == ItemID.ShadowCandle)
                {
                    inTown = false;
                    inTownWithRain = false;
                    inUgTown = false;
                }
                else
                {
                    inTown = player.townNPCs > 2f && ((notRaining && player.ZoneOverworldHeight) || inSpace);
                    inTownWithRain = player.townNPCs > 2f && isRaining;
                    inUgTown = player.townNPCs > 2f && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight || player.ZoneUnderworldHeight);
                }
            }
            if (calamityMod)
            {
                ZoneBrimstoneCrags = (bool)calamity.Call("GetInZone", player, "crags");
                ZoneAstralInfection = (bool)calamity.Call("GetInZone", player, "astral");
                ZoneAbyss = (bool)calamity.Call("GetInZone", player, "abyss");
                ZoneSunkenSea = (bool)calamity.Call("GetInZone", player, "sunkensea");
                BossRushActive = (bool)calamity.Call("GetDifficultyActive", "bossrushactive");
            }

            if (infernumMod)
            {
                infernumMode = (bool)infernum.Call("GetInfernumActive");
                ZoneProfanedTemple = player.InModBiome(infernum.Find<ModBiome>("ProfanedTempleBiome"));
            }

            CalamityMusicEventInactive = CalamityMusicEvent() == null;
            VCalamityMusicEventInactive = VCalamityMusicEvent() == null;
        }
        // 跟踪原灾音乐事件播放
        public static DateTime? CalamityMusicEvent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamity))
            {
                Type musicEventType = calamity.GetType().Assembly.GetType("CalamityMod.Systems.MusicEventSystem");

                if (musicEventType != null)
                {
                    PropertyInfo trackStartProperty = musicEventType.GetProperty("TrackStart", BindingFlags.Static | BindingFlags.Public);
                    DateTime? trackStartValue = trackStartProperty.GetValue(null) as DateTime?;

                    return trackStartValue;
                }
            }
            return null;
        }
        // 跟踪VCMM音乐事件播放
        public static DateTime? VCalamityMusicEvent()
        {
            if (ModLoader.TryGetMod("UnCalamityModMusic", out Mod calamity))
            {
                Type musicEventType = calamity.GetType().Assembly.GetType("UnCalamityModMusic.Common.MusicEvents");

                if (musicEventType != null)
                {
                    PropertyInfo trackStartProperty = musicEventType.GetProperty("TrackStart", BindingFlags.Static | BindingFlags.Public);
                    DateTime? trackStartValue = trackStartProperty.GetValue(null) as DateTime?;

                    return trackStartValue;
                }
            }
            return null;
        }
    }
}
