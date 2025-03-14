using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using EnderLiliesMusicPack.Config;
using EnderLiliesMusicPack.LiliesPlayer;
using Terraria.ID;

namespace EnderLiliesMusicPack.Scenes.MusicScenes
{
    public class BiomeMusicScenes : ModSystem
    {
        #region 森林
        //森林夜晚
        public class ForestNight : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Grudge");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return !Main.dayTime && player.ZoneOverworldHeight && !player.ZoneBeach && LiliesMusicPackBiomeConfig.Instance.Forest;
            }
        }
        //森林白天
        public class ForestDayMorning : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Harmonious");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.time >= 10800 && Main.time < 27000 && Main.dayTime && player.ZoneOverworldHeight && !(player.ZoneBeach || player.ZoneHallow) && LiliesMusicPackBiomeConfig.Instance.Forest;
            }

            public override void SpecialVisuals(Player player, bool isActive)
            {
                if (isActive && Main.time >= 10800 && Main.time < 11100 && Main.curMusic == Music && Main.musicFade[Main.curMusic] < 0.25f && Main.dayRate == 1)
                {
                    Main.musicFade[Main.curMusic] = 0.25f;
                }
            }
        }
        // 森林白天下午
        public class ForestDayAfternoon : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Dewdrop");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.time >= 27000 && Main.time < 43200 && Main.dayTime && player.ZoneOverworldHeight && !(player.ZoneBeach || player.ZoneHallow) && LiliesMusicPackBiomeConfig.Instance.Forest;
            }

            public override void SpecialVisuals(Player player, bool isActive)
            {
                if (isActive && Main.time >= 27000 && Main.time < 27300 && Main.curMusic == Music && Main.musicFade[Main.curMusic] < 0.25f && Main.dayRate == 1)
                {
                    Main.musicFade[Main.curMusic] = 0.25f;
                }
            }
        }
        #endregion
        #region 地下
        public class Underground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/HarmoniousInst");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && !(player.ZoneBeach || player.ZoneHallow) && LiliesMusicPackBiomeConfig.Instance.UnderGround;
            }
        }

        public class Caverns : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Theforsaken");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = LiliesPlayerFlags.largeWorld && player.ZoneRockLayerHeight && player.position.Y > Main.rockLayer * 24.2 + Main.screenHeight / 2;
                bool condition2 = LiliesPlayerFlags.mediumWorld && player.ZoneRockLayerHeight && player.position.Y > Main.rockLayer * 25.8 + Main.screenHeight / 2;
                bool condition3 = LiliesPlayerFlags.smallWorld && player.ZoneRockLayerHeight && player.position.Y > Main.rockLayer * 25 + Main.screenHeight / 2;

                return (condition1 || condition2 || condition3) && !(player.ZoneBeach || player.ZoneHallow) && LiliesMusicPackBiomeConfig.Instance.UnderGround;
            }
        }

        #endregion
        #region 地狱
        public class Underworld : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Root");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneUnderworldHeight && !(LiliesPlayerFlags.ZoneBrimstoneCrags || LiliesPlayerFlags.ZoneProfanedTemple) && LiliesMusicPackBiomeConfig.Instance.UnderWorld;
            }
        }
        #endregion
        #region 太空
        //肉前
        public class Space : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/MagiccoalmineSaveVer");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return LiliesPlayerFlags.inSpace && LiliesMusicPackBiomeConfig.Instance.Space && !Main.hardMode;
            }
        }
        //肉后
        public class SpacePF : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Magiccoalmine");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return LiliesPlayerFlags.inSpace && LiliesMusicPackBiomeConfig.Instance.Space && Main.hardMode;
            }
        }
        #endregion
        #region 雪地
        public class Snow : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/NorthSave");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneSnow && player.ZoneOverworldHeight && !Main.hardMode && LiliesMusicPackBiomeConfig.Instance.Snow;
            }
        }
        public class SnowPF : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/North");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneSnow && player.ZoneOverworldHeight && Main.hardMode && LiliesMusicPackBiomeConfig.Instance.Snow;
            }
        }
        // 雪地地下
        public class SnowUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/BloomOutro");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneSnow && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && LiliesMusicPackBiomeConfig.Instance.Snow;
            }
        }
        #endregion
        #region 沙漠
        public class Desert : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Veol");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneDesert && !LiliesPlayerFlags.ugDesertOriginalHeight && LiliesMusicPackBiomeConfig.Instance.Desert;
            }
        }
        public class DesertUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Sweat");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                bool ugDesertHeight = player.position.Y >= Main.worldSurface * 14 + (double)Main.screenHeight / 2;

                return player.ZoneUndergroundDesert && ugDesertHeight && !player.ZoneBeach && LiliesMusicPackBiomeConfig.Instance.Desert;
            }
        }
        #endregion
        #region 丛林
        public class Jungle : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/TheWitchsBreath");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneDesert && !LiliesPlayerFlags.ugDesertOriginalHeight && !Main.hardMode && LiliesMusicPackBiomeConfig.Instance.Jungle;
            }
        }
        public class JunglePF : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/TheWitchsBreathSave");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneJungle && player.ZoneOverworldHeight && !player.ZoneMeteor && Main.hardMode && LiliesMusicPackBiomeConfig.Instance.Jungle;
            }
        }
        public class JungleUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Taboo");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneJungle && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && !player.ZoneMeteor && LiliesMusicPackBiomeConfig.Instance.Jungle;
            }
        }
        // 丛林神庙
        public class JungleTemple : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Abandonment");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneLihzhardTemple && LiliesMusicPackBiomeConfig.Instance.Jungle;
            }
        }
        #endregion
        #region 海洋
        public class OceanDay : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Confidentiality");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.dayTime && player.ZoneBeach && LiliesMusicPackBiomeConfig.Instance.Ocean;
            }
        }
        public class OceanNight : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/WhiteSaveVer");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return !Main.dayTime && player.ZoneBeach && LiliesMusicPackBiomeConfig.Instance.Ocean;
            }
        }
        #endregion
        #region 蘑菇地
        public class GlowingMushroomFields : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/CompoundingSave");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneGlowshroom && LiliesMusicPackBiomeConfig.Instance.MushroomFields;
            }
        }
        #endregion
        #region 邪恶地形
        // 腐化
        public class Corruption : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Asecret");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneCorrupt && player.ZoneOverworldHeight && LiliesMusicPackBiomeConfig.Instance.EvilBiome;
            }
        }
        public class CorruptionUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Nectar");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneCorrupt && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && !(LiliesPlayerFlags.ZoneAstralInfection || LiliesPlayerFlags.ZoneSunkenSea || LiliesPlayerFlags.ZoneAbyss) && LiliesMusicPackBiomeConfig.Instance.EvilBiome;
            }
        }
        // 猩红
        public class Crimson : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Evilintro");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneCrimson && player.ZoneOverworldHeight && !(LiliesPlayerFlags.ZoneAstralInfection || LiliesPlayerFlags.ZoneSunkenSea || LiliesPlayerFlags.ZoneAbyss) && LiliesMusicPackBiomeConfig.Instance.EvilBiome;
            }
        }
        public class CrimsonUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/IfYouGazeLongintoanAbyss");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneCrimson && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && !(LiliesPlayerFlags.ZoneAstralInfection || LiliesPlayerFlags.ZoneSunkenSea || LiliesPlayerFlags.ZoneAbyss) && LiliesMusicPackBiomeConfig.Instance.EvilBiome;
            }
        }
        #endregion
        #region 神圣
        public class Hallow : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/HolyLand");
            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.dayTime && player.ZoneHallow && player.ZoneOverworldHeight && LiliesMusicPackBiomeConfig.Instance.Hallow;
            }
        }
        public class HallowUnderground : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Metallicnoise");
            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneHallow && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight) && LiliesMusicPackBiomeConfig.Instance.Hallow;
            }
        }

        #endregion
        #region 地牢
        public class Dungeon : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/DebrisandBugs");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneDungeon && LiliesMusicPackBiomeConfig.Instance.Dungeon;
            }
        }
        #endregion
        #region 微光
        public class Aether : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Seeyoulater");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneShimmer && LiliesMusicPackBiomeConfig.Instance.Aether;
            }
        }
        #endregion
        #region 墓地
        public class Graveyard : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Biome/Prologue");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneGraveyard;
            }
        }
        #endregion
    }
}
