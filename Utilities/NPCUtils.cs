using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace EnderLiliesMusicPack.Utilities
{
    public static partial class NPCUtils
    {
        /// <summary>
        /// 这个用来去找玩家附近是否存在这个NPC，不要求必须活跃
        /// </summary>
        /// <param name="npcType">NPC单位</param>
        /// <param name="player">玩家单位</param>
        /// <param name="range">最大检索距离</param>
        /// <returns>真:表示有这个npc</returns>
        public static bool IsThereNpcNearby(int npcType, Player player, float range)
        {
            if (npcType <= 0)
                return false;
            int npcIndex = NPC.FindFirstNPC(npcType);
            if (npcIndex != -1)
            {
                NPC npc = Main.npc[npcIndex];
                return npc.Distance(player.Center) <= range;
            }
            return false;
        }
        /// <summary>
        /// 这个用来去找玩家附近是否存在这个NPC，必须活跃且存在
        /// </summary>
        /// <param name="npcType">NPC单位</param>
        /// <param name="player">玩家单位</param>
        /// <param name="range">最大检索距离</param>
        /// <returns>真:表示有这个npc</returns>
        public static bool IsThereNpcNearbyAndActive(int npcType, Player player, float range)
        {
            if (npcType <= 0)
                return false;
            int npcIndex = NPC.FindFirstNPC(npcType);
            if (npcIndex != -1)
            {
                NPC npc = Main.npc[npcIndex];
                return npc.active && npc.Distance(player.Center) <= range;
            }
            return false;
        }
        /// <summary>
        /// 这个用来去找玩家附近是否存在这个NPC，必须活跃且存在，并且无敌状态
        /// </summary>
        /// <param name="npcType">NPC单位</param>
        /// <param name="player">玩家单位</param>
        /// <param name="range">最大检索距离</param>
        /// <returns>真:表示有这个npc</returns>
        public static bool IsThereNpcNearbyAndchaseable(int npcType, Player player, float range)
        {
            if (npcType <= 0)
                return false;
            int npcIndex = NPC.FindFirstNPC(npcType);
            if (npcIndex != -1)
            {
                NPC npc = Main.npc[npcIndex];
                return npc.active && npc.Distance(player.Center) <= range && npc.chaseable;
            }
            return false;
        }
        /// <summary>
        /// 这个用来去找玩家附近是否存在这个NPC，必须活跃且存在
        /// </summary>
        /// <param name="npcType">NPC单位</param>
        /// <param name="player">玩家单位</param>
        /// <param name="range">最大检索距离</param>
        /// <param name="requiredCount">检索到的NPC数量要求</param>
        /// <returns>真:表示有这个npc</returns>
        public static bool IsThereNpcNearbyAndActiveCount(int npcType, Player player, float range, int requiredCount = 1)
        {
            if (npcType <= 0 || requiredCount <= 0)
                return false;

            int count = 0;
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (npc.active && npc.type == npcType && npc.Distance(player.Center) <= range)
                {
                    count++;
                    if (count >= requiredCount)
                        return true; // 提前退出，提高效率
                }
            }
            return count >= requiredCount;
        }
    }
}
