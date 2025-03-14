using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using EnderLiliesMusicPack.Config;
using EnderLiliesMusicPack.Utilities;
using EnderLiliesMusicPack.LiliesPlayer;
using Terraria.GameContent.Events;

namespace EnderLiliesMusicPack.Scenes.MusicScenes
{
    public class EventMusicScenes : ModSystem
    {
        #region 四柱
        public class LunarTowersSolar : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/TheSunOutro");

            public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneTowerSolar && LiliesMusicPackEventConfig.Instance.LunarTowers;
            }
        }
        public class LunarTowersNebula : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/EvilOutro");

            public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneTowerNebula && LiliesMusicPackEventConfig.Instance.LunarTowers;
            }
        }
        public class LunarTowersVortex : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/Root");

            public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneTowerVortex && LiliesMusicPackEventConfig.Instance.LunarTowers;
            }
        }
        public class LunarTowersStardust : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/White");

            public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return player.ZoneTowerStardust && LiliesMusicPackEventConfig.Instance.LunarTowers;
            }
        }
        #endregion
        #region 雨天和灯笼节
        public class Rain : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/ANocturneforAll");

            public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = !Main.remixWorld && LiliesPlayerFlags.isRaining && LiliesPlayerFlags.ZoneOverworldHeightExtra && !(player.ZoneSnow || player.ZoneGraveyard);
                bool condition2 = Main.remixWorld && LiliesPlayerFlags.isRaining && (double)(player.position.Y / 16f) > Main.rockLayer && player.position.Y / 16f < (float)(Main.maxTilesY - 350) && !(player.ZoneSnow || player.ZoneGraveyard);

                return (condition1 || condition2 ) && LiliesMusicPackEventConfig.Instance.Rain;
            }
        }
        public class LanternFestival : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/MainThemePianoEdit");

            public override SceneEffectPriority Priority => LiliesPlayerFlags.inTown ? SceneEffectPriority.Environment : SceneEffectPriority.BiomeMedium;

            public override bool IsSceneEffectActive(Player player)
            {
                return LanternNight.LanternsUp && LiliesPlayerFlags.ZoneOverworldHeightExtra && LiliesPlayerFlags.notRaining && !(player.ZoneGraveyard || player.ZoneMeteor);
            }
        }
        #endregion
        #region 沙尘暴与暴风雪
        public class Sandstorm : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/Pulsation");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = !Main.remixWorld && LiliesPlayerFlags.ZoneSandstorm && !LiliesPlayerFlags.ugDesertOriginalHeight && !LiliesPlayerFlags.inSpace  && !(Main.bloodMoon || Main.eclipse);
                bool condition2 = Main.remixWorld && LiliesPlayerFlags.ZoneSandstorm && !LiliesPlayerFlags.inSpace && !(Main.bloodMoon || Main.eclipse);

                return condition1 || condition2;
            }
        }
        #endregion
        #region 血月
        public class BloodMoon : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/Homunculus");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = !Main.remixWorld && Main.bloodMoon && LiliesPlayerFlags.onSurface && !(LiliesPlayerFlags.inSpace || player.ZoneCorrupt || player.ZoneCrimson || LiliesPlayerFlags.ZoneAstralInfection);
                bool condition2 = Main.remixWorld && Main.bloodMoon && (double)Main.LocalPlayer.position.Y > Main.rockLayer * 16.0 && player.position.Y <= (float)(Main.UnderworldLayer * 16) && !(player.ZoneCorrupt || player.ZoneCrimson || LiliesPlayerFlags.ZoneAstralInfection);
                bool condition3 = Main.remixWorld && Main.bloodMoon && player.position.Y > (float)(Main.UnderworldLayer * 16) && (double)(player.Center.X / 16f) > (double)Main.maxTilesX * 0.37 + 50.0 && (double)(player.Center.X / 16f) < (double)Main.maxTilesX * 0.63;

                return condition1 || condition2 || condition3;
            }
        }

        #endregion
        #region 日蚀
        public class Eclipse : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Event/AccoladeOutro");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = !Main.remixWorld && Main.eclipse && LiliesPlayerFlags.onSurface && !(LiliesPlayerFlags.inSpace || player.ZoneCorrupt || player.ZoneCrimson || LiliesPlayerFlags.ZoneAstralInfection);
                bool condition2 = Main.remixWorld && Main.eclipse && (double)Main.LocalPlayer.position.Y > Main.rockLayer * 16.0 && player.position.Y <= (float)(Main.UnderworldLayer * 16) && !(player.ZoneCorrupt || player.ZoneCrimson || LiliesPlayerFlags.ZoneAstralInfection);
                bool condition3 = Main.remixWorld && Main.eclipse && player.position.Y > (float)(Main.UnderworldLayer * 16) && (double)(player.Center.X / 16f) > (double)Main.maxTilesX * 0.37 + 50.0 && (double)(player.Center.X / 16f) < (double)Main.maxTilesX * 0.63;

                return condition1 || condition2 || condition3;
            }
        }

        #endregion
    }
}
