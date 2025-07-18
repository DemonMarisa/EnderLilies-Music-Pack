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
using EnderLiliesMusicPack.Core.BossMusicOverride;

namespace EnderLiliesMusicPack.Scenes.MusicScenes
{
    public class BossMusicScenes : ModSystem
    {
        #region 血肉墙前
        #region 史莱姆王
        public class KingSlime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Nervousness");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideKingSlimeMusic && LiliesMusicPackBossConfig.Instance.KingSlime;
            }
        }
        #endregion
        #region 克眼
        public class EyeOC : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/CommunicationIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideEOCMusic && LiliesMusicPackBossConfig.Instance.EyeOC;
            }
        }
        #endregion
        #region 世吞
        public class EOW : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/RosaryOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideEOWMusic && LiliesMusicPackBossConfig.Instance.BOC;
            }
        }
        #endregion
        #region 克脑
        public class BOC : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/HelplessnessOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideBOCMusic && LiliesMusicPackBossConfig.Instance.BOC;
            }
        }
        #endregion
        #region 蜂王
        public class QueenBee : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Gewalt");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideQueenBeeMusic && LiliesMusicPackBossConfig.Instance.QueenBee;
            }
        }
        #endregion
        #region 骷髅王
        public class Skeletron : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/CommunicationOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)10;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideSkeletronMusic && LiliesMusicPackBossConfig.Instance.Skeletron;
            }
        }
        #endregion
        #region 巨鹿
        public class Deerclops : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/BloomIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)10;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideDeerclopsMusic && LiliesMusicPackBossConfig.Instance.Deerclops;
            }
        }
        #endregion
        #region 血肉墙
        public class WallofFlesh : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/AccoladeOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideWallofFleshMusic && LiliesMusicPackBossConfig.Instance.WOF;
            }
        }
        #endregion
        #endregion
        #region 困难模式boss
        #region 史莱姆女皇
        public class QueenSlime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/SiegridSilva");

            public override SceneEffectPriority Priority => (SceneEffectPriority)13;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideQueenSlimeMusic && LiliesMusicPackBossConfig.Instance.QueenSlimeBoss;
            }
        }
        #endregion
        #region 双子
        public class TheTwins : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Gilroy");

            public override SceneEffectPriority Priority => (SceneEffectPriority)13;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideTheTwinsMusic && LiliesMusicPackBossConfig.Instance.TheTwins;
            }
        }
        #endregion
        #region 毁灭者
        public class TheDestroyer : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Akey");

            public override SceneEffectPriority Priority => (SceneEffectPriority)13;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideTheDestroyerMusic && LiliesMusicPackBossConfig.Instance.TheDestroyer;
            }
        }
        #endregion
        #region 机械骷髅王
        public class SkeletronPrime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Humanity");

            public override SceneEffectPriority Priority => (SceneEffectPriority)13;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideSkeletronPrimeMusic && LiliesMusicPackBossConfig.Instance.SkeletronPrime;
            }
        }
        #endregion
        #region 世花
        public class Plantera : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/VD");

            public override SceneEffectPriority Priority => (SceneEffectPriority)14;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overridePlanteraMusic && LiliesMusicPackBossConfig.Instance.Plantera;
            }
        }
        #endregion
        #region 石小人
        // fuck you Calamity
        public class Golem : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/TheSunIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)14;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideGolemMusic && LiliesMusicPackBossConfig.Instance.Golem;
            }
        }
        #endregion
        #region 光女
        public class EOL : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Lilytree");

            public override SceneEffectPriority Priority => (SceneEffectPriority)14;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideEOLMusic && LiliesMusicPackBossConfig.Instance.EOL;
            }
        }
        #endregion
        #region 猪鲨
        public class DukeFishron : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Shingari");

            public override SceneEffectPriority Priority => (SceneEffectPriority)14;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideDukeFishronMusic && LiliesMusicPackBossConfig.Instance.DukeFish;
            }
        }
        #endregion
        #region 邪教徒
        public class LunaticCultist : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Magnoliadenudata");

            public override SceneEffectPriority Priority => (SceneEffectPriority)15;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideLunaticCultistMusic && LiliesMusicPackBossConfig.Instance.LunaticCultist;
            }
        }
        #endregion
        #region 月球领主
        public class MoonLord : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/MotherIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)15;

            public override bool IsSceneEffectActive(Player player)
            {
                LiliesPlayerFlags liliesPlayer = player.LiliesPlayer();

                return BossMusicOverride.overrideMoonLordMusic && LiliesMusicPackBossConfig.Instance.MoonLordMother;
            }
        }
        public class MoonLordP2 : ModSceneEffect
        {

            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/MotherOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)16;

            public override bool IsSceneEffectActive(Player player)
            {
                return BossMusicOverride.overrideMoonLordP2Music && LiliesMusicPackBossConfig.Instance.MoonLordMother;
            }
        }
        #endregion
        #endregion
    }
}
