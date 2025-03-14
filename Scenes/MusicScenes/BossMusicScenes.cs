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

namespace EnderLiliesMusicPack.Scenes.MusicScenes
{
    public class BossMusicScenes : ModSystem
    {
        #region 血肉墙前
        #region 史莱姆王
        public class KingSlime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Nervousness");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool KingSlimeActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.KingSlime, player, 8500f);
                return KingSlimeActive && LiliesMusicPackBossConfig.Instance.KingSlime;
            }
        }
        #endregion
        #region 克眼
        public class EyeOC : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/CommunicationIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool EyeOCActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.EyeofCthulhu, player, 8500f);
                return EyeOCActive && LiliesMusicPackBossConfig.Instance.EyeOC;
            }
        }
        #endregion
        #region 世吞
        public class EOC : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/RosaryOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool EOCActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.EaterofWorldsHead, player, 8500f);
                return EOCActive && LiliesMusicPackBossConfig.Instance.BOC;
            }
        }
        #endregion
        #region 克脑
        public class BOC : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/HelplessnessOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool BOCActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.BrainofCthulhu, player, 8500f);
                return BOCActive && LiliesMusicPackBossConfig.Instance.BOC;
            }
        }
        #endregion
        #region 蜂王
        public class QueenBee : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Gewalt");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool QueenBeeActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.QueenBee, player, 8500f);
                return QueenBeeActive && LiliesMusicPackBossConfig.Instance.QueenBee;
            }
        }
        #endregion
        #region 骷髅王
        public class Skeletron : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/CommunicationOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool SkeletronActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.SkeletronHead, player, 8500f);
                return SkeletronActive && LiliesMusicPackBossConfig.Instance.Skeletron;
            }
        }
        #endregion
        #region 巨鹿
        public class Deerclops : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/BloomIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)8;

            public override bool IsSceneEffectActive(Player player)
            {
                bool DeerclopsActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.Deerclops, player, 8500f);
                return DeerclopsActive && LiliesMusicPackBossConfig.Instance.Deerclops;
            }
        }
        #endregion
        #region 血肉墙
        public class WallofFlesh : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/AccoladeOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)9;

            public override bool IsSceneEffectActive(Player player)
            {
                bool WallofFleshActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.WallofFlesh, player, 8500f);
                return WallofFleshActive && LiliesMusicPackBossConfig.Instance.WOF;
            }
        }
        #endregion
        #endregion
        #region 困难模式boss
        #region 史莱姆女皇
        public class QueenSlime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/SiegridSilva");

            public override SceneEffectPriority Priority => (SceneEffectPriority)9;

            public override bool IsSceneEffectActive(Player player)
            {
                bool QueenSlimeActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.QueenSlimeBoss, player, 8500f);
                return QueenSlimeActive && LiliesMusicPackBossConfig.Instance.QueenSlimeBoss;
            }
        }
        #endregion
        #region 双子
        public class TheTwins : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Sweat");

            public override SceneEffectPriority Priority => (SceneEffectPriority)9;

            public override bool IsSceneEffectActive(Player player)
            {
                bool TheTwinsActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.Retinazer, player, 8500f) || NPCUtils.IsThereNpcNearbyAndActive(NPCID.Spazmatism, player, 8500f);
                return TheTwinsActive && LiliesMusicPackBossConfig.Instance.TheTwins;
            }
        }
        #endregion
        #region 毁灭者
        public class TheDestroyer : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Akey");

            public override SceneEffectPriority Priority => (SceneEffectPriority)9;

            public override bool IsSceneEffectActive(Player player)
            {
                bool TheDestroyerActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.TheDestroyer, player, 8500f);
                return TheDestroyerActive && LiliesMusicPackBossConfig.Instance.TheDestroyer;
            }
        }
        #endregion
        #region 机械骷髅王
        public class SkeletronPrime : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Humanity");

            public override SceneEffectPriority Priority => (SceneEffectPriority)9;

            public override bool IsSceneEffectActive(Player player)
            {
                bool SkeletronPrimeActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.SkeletronPrime, player, 8500f);
                return SkeletronPrimeActive && LiliesMusicPackBossConfig.Instance.SkeletronPrime;
            }
        }
        #endregion
        #region 世花
        public class Plantera : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/VD");

            public override SceneEffectPriority Priority => (SceneEffectPriority)10;

            public override bool IsSceneEffectActive(Player player)
            {
                bool PlanteraActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.Plantera, player, 8500f);
                return PlanteraActive && LiliesMusicPackBossConfig.Instance.Plantera;
            }
        }
        #endregion
        #region 石小人
        // fuck you Calamity
        public class Golem : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/TheSunIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)11;

            public override bool IsSceneEffectActive(Player player)
            {
                bool GolemActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.Golem, player, 8500f);
                return GolemActive && LiliesMusicPackBossConfig.Instance.Golem;
            }
        }
        #endregion
        #region 光女
        public class EOL : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Lilytree");

            public override SceneEffectPriority Priority => (SceneEffectPriority)11;

            public override bool IsSceneEffectActive(Player player)
            {
                bool EOLActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.HallowBoss, player, 8500f);
                return EOLActive && LiliesMusicPackBossConfig.Instance.EOL;
            }
        }
        #endregion
        #region 猪鲨
        public class DukeFishron : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Shingari");

            public override SceneEffectPriority Priority => (SceneEffectPriority)11;

            public override bool IsSceneEffectActive(Player player)
            {
                bool DukeFishronActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.DukeFishron, player, 8500f);
                return DukeFishronActive && LiliesMusicPackBossConfig.Instance.DukeFish;
            }
        }
        #endregion
        #region 邪教徒
        public class LunaticCultist : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/Magnoliadenudata");

            public override SceneEffectPriority Priority => (SceneEffectPriority)12;

            public override bool IsSceneEffectActive(Player player)
            {
                bool LunaticCultistActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.CultistBoss, player, 8500f);
                return LunaticCultistActive && LiliesMusicPackBossConfig.Instance.LunaticCultist;
            }
        }
        #endregion
        #region 月球领主
        public class MoonLord : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/MotherIntro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)13;

            public override bool IsSceneEffectActive(Player player)
            {
                bool MoonLordHandActive = NPCUtils.IsThereNpcNearbyAndActive(NPCID.MoonLordCore, player, 8500f);
                return MoonLordHandActive && LiliesMusicPackBossConfig.Instance.MoonLordMother;
            }
        }
        public class MoonLordP2 : ModSceneEffect
        {
            public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Boss/MotherOutro");

            public override SceneEffectPriority Priority => (SceneEffectPriority)14;

            public override bool IsSceneEffectActive(Player player)
            {
                bool MoonLordP2Active = NPCUtils.IsThereNpcNearbyAndActiveCount(NPCID.MoonLordFreeEye, player, 8500f, 3);
                return MoonLordP2Active && LiliesMusicPackBossConfig.Instance.MoonLordMother;
            }
        }
        #endregion
        #endregion
    }
}
