using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using EnderLiliesMusicPack.Utilities;
using EnderLiliesMusicPack.LiliesPlayer;

namespace EnderLiliesMusicPack.Core.BossMusicOverride
{
    public class BossMusicGlobalAI : GlobalNPC
    {
        public override void PostAI(NPC npc)
        {
            #region 肉前
            // 史莱姆王
            if (npc.type == NPCID.KingSlime)
                BossMusicOverride.overrideKingSlimeMusic = true;
            // 克眼
            if (npc.type == NPCID.EyeofCthulhu)
                BossMusicOverride.overrideEOCMusic = true;
            // 世吞
            if (npc.type == NPCID.EaterofWorldsHead)
                BossMusicOverride.overrideEOWMusic = true;
            // 克脑
            if (npc.type == NPCID.BrainofCthulhu)
                BossMusicOverride.overrideBOCMusic = true;
            // 蜂王
            if (npc.type == NPCID.QueenBee)
                BossMusicOverride.overrideQueenBeeMusic = true;
            // 骷髅王
            if ( npc.type == NPCID.SkeletronHead)
                BossMusicOverride.overrideSkeletronMusic = true;
            // 巨鹿
            if (npc.type == NPCID.Deerclops)
                BossMusicOverride.overrideDeerclopsMusic = true;
            // 肉山
            if (npc.type == NPCID.WallofFlesh)
                BossMusicOverride.overrideWallofFleshMusic = true;
            #endregion
            #region 肉后
            // 史后
            if (npc.type == NPCID.QueenSlimeBoss)
                BossMusicOverride.overrideQueenSlimeMusic = true;
            // 双子
            if (npc.type == NPCID.Spazmatism || npc.type == NPCID.Retinazer)
                BossMusicOverride.overrideTheTwinsMusic = true;
            // 毁灭者
            if (npc.type == NPCID.TheDestroyer)
                BossMusicOverride.overrideTheDestroyerMusic = true;
            // 机械骷髅王
            if (npc.type == NPCID.SkeletronPrime)
                BossMusicOverride.overrideSkeletronPrimeMusic = true;
            // 世纪之花
            if (npc.type == NPCID.Plantera)
                BossMusicOverride.overridePlanteraMusic = true;
            // 石巨人
            if (npc.type == NPCID.Golem)
                BossMusicOverride.overrideGolemMusic = true;
            // 光女
            if (npc.type == NPCID.HallowBoss)
                BossMusicOverride.overrideEOLMusic = true;
            // 猪鲨
            if (npc.type == NPCID.DukeFishron)
                BossMusicOverride.overrideDukeFishronMusic = true;
            // 邪教徒
            if (npc.type == NPCID.CultistBoss)
                BossMusicOverride.overrideLunaticCultistMusic = true;
            // 月
            if (npc.type == NPCID.MoonLordCore)
            {
                bool MoonLordP2Active = NPCUtils.IsThereNpcNearbyAndActiveCount(NPCID.MoonLordFreeEye, 3);

                if (MoonLordP2Active)
                {
                    BossMusicOverride.overrideMoonLordP2Music = true;
                }
                else
                    BossMusicOverride.overrideMoonLordMusic = true;
            }
            #endregion
        }
        public override void OnKill(NPC npc)
        {
            #region 肉前
            // 史莱姆王
            if (npc.type == NPCID.KingSlime)
                BossMusicOverride.overrideKingSlimeMusic = false;
            // 克眼
            if (npc.type == NPCID.EyeofCthulhu)
                BossMusicOverride.overrideEOCMusic = false;
            // 世吞
            if (npc.type == NPCID.EaterofWorldsHead)
                BossMusicOverride.overrideEOWMusic = false;
            // 克脑
            if (npc.type == NPCID.BrainofCthulhu)
                BossMusicOverride.overrideBOCMusic = false;
            // 蜂王
            if (npc.type == NPCID.QueenBee)
                BossMusicOverride.overrideQueenBeeMusic = false;
            // 骷髅王
            if (npc.type == NPCID.SkeletronHead)
                BossMusicOverride.overrideSkeletronMusic = false;
            // 巨鹿
            if (npc.type == NPCID.Deerclops)
                BossMusicOverride.overrideDeerclopsMusic = false;
            // 肉山
            if (npc.type == NPCID.WallofFlesh)
                BossMusicOverride.overrideWallofFleshMusic = false;
            #endregion
            #region 肉后
            if (npc.type == NPCID.QueenSlimeBoss)
                BossMusicOverride.overrideQueenSlimeMusic = false;
            // 双子
            if (npc.type == NPCID.Spazmatism || npc.type == NPCID.Retinazer)
                BossMusicOverride.overrideTheTwinsMusic = false;
            // 毁灭者
            if (npc.type == NPCID.TheDestroyer)
                BossMusicOverride.overrideTheDestroyerMusic = false;
            // 机械骷髅王
            if (npc.type == NPCID.SkeletronPrime)
                BossMusicOverride.overrideSkeletronPrimeMusic = false;
            // 世纪之花
            if (npc.type == NPCID.Plantera)
                BossMusicOverride.overridePlanteraMusic = false;
            // 石巨人
            if (npc.type == NPCID.Golem)
                BossMusicOverride.overrideGolemMusic = false;
            // 光女
            if (npc.type == NPCID.HallowBoss)
                BossMusicOverride.overrideEOLMusic = false;
            // 猪鲨
            if (npc.type == NPCID.DukeFishron)
                BossMusicOverride.overrideDukeFishronMusic = false;
            // 邪教徒
            if (npc.type == NPCID.CultistBoss)
                BossMusicOverride.overrideLunaticCultistMusic = false;
            // 月
            if (npc.type == NPCID.MoonLordCore)
            {
                BossMusicOverride.overrideMoonLordP2Music = false;
                BossMusicOverride.overrideMoonLordMusic = false;
            }
            #endregion
        }
    }
}
