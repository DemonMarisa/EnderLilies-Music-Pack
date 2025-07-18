using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using EnderLiliesMusicPack.Utilities;

namespace EnderLiliesMusicPack.Core.BossMusicOverride
{
    public class BossMusicOverride : ModSystem
    {
        #region 肉前
        public static bool overrideKingSlimeMusic = false;
        public static bool overrideEOCMusic = false;
        public static bool overrideEOWMusic = false;
        public static bool overrideBOCMusic = false;
        public static bool overrideQueenBeeMusic = false;
        public static bool overrideSkeletronMusic = false;
        public static bool overrideDeerclopsMusic = false;
        public static bool overrideWallofFleshMusic = false;
        #endregion
        #region 肉后 
        // 史后
        public static bool overrideQueenSlimeMusic = false;
        // 双子
        public static bool overrideTheTwinsMusic = false;
        // 毁灭者
        public static bool overrideTheDestroyerMusic = false;
        // 机械骷髅王
        public static bool overrideSkeletronPrimeMusic = false;
        // 世纪之花
        public static bool overridePlanteraMusic = false;
        // 石巨人
        public static bool overrideGolemMusic = false;
        // 光女
        public static bool overrideEOLMusic = false;
        // 猪鲨
        public static bool overrideDukeFishronMusic = false;
        // 邪教徒
        public static bool overrideLunaticCultistMusic = false;
        // 月
        public static bool overrideMoonLordMusic = false;
        // 月二阶段
        public static bool overrideMoonLordP2Music = false;
        #endregion
        public override void PreUpdateNPCs()
        {
            #region 肉前
            overrideKingSlimeMusic = false;
            overrideEOCMusic = false;
            overrideEOWMusic = false;
            overrideBOCMusic = false;
            overrideQueenBeeMusic = false;
            overrideSkeletronMusic = false;
            overrideDeerclopsMusic = false;
            overrideWallofFleshMusic = false;
            #endregion
            #region 肉后
            overrideQueenSlimeMusic = false;
            overrideTheTwinsMusic = false;
            overrideTheDestroyerMusic = false;
            overrideSkeletronPrimeMusic = false;
            overridePlanteraMusic = false;
            overrideGolemMusic = false;
            overrideEOLMusic = false;
            overrideDukeFishronMusic = false;
            overrideLunaticCultistMusic = false;
            overrideMoonLordMusic = false;
            if (!NPCUtils.IsThereNpcNearbyAndActiveNorange(NPCID.MoonLordCore))
                overrideMoonLordP2Music = false;
            #endregion
        }
    }
}
