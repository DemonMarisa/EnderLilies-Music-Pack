using EnderLiliesMusicPack.Config;
using EnderLiliesMusicPack.LiliesPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Scenes.MusicScenes
{
    public class TownMusicScenes : ModSystem
    {
        #region 城镇日常
        #region 肉前
        public class TownNight : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/SymbiosisSaveVer");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return !Main.dayTime && !Main.hardMode && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        public class TownDay : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/DignitySaveVer");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.dayTime && !Main.hardMode && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        #endregion
        #region 肉后月前
        //肉山后月前
        public class TownDayPF : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/Dignity");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.dayTime && !NPC.downedMoonlord && Main.hardMode && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        public class TownNightPF : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/Symbiosis");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return !Main.dayTime && !NPC.downedMoonlord && Main.hardMode && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        #endregion
        #region 月后
        public class TownDayPM : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/HeartsStayUnchanged");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return Main.dayTime && NPC.downedMoonlord && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        public class TownNightPM : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/TheWhiteWitch");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return !Main.dayTime && NPC.downedMoonlord && (LiliesPlayerFlags.inTown || LiliesPlayerFlags.inUgTown) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        #endregion
        #endregion
        #region 城镇事件
        public class TownParty : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/Eachpersonsdream");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment + 1;

            public override bool IsSceneEffectActive(Player player)
            {
                bool condition1 = BirthdayParty.PartyIsUp && LiliesPlayerFlags.inTown;
                bool condition2 = BirthdayParty.PartyIsUp && LiliesPlayerFlags.inUgTown;

                return (condition1 || condition2) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        public class TownRain : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Town/Yearning");

            public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

            public override bool IsSceneEffectActive(Player player)
            {
                return LiliesPlayerFlags.inTownWithRain && !(player.ZoneBeach || player.ZoneSnow || player.ZoneGraveyard || player.ZoneMeteor) && LiliesMusicPackBiomeConfig.Instance.Town;
            }
        }
        #endregion
    }
}
